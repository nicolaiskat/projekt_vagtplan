BEGIN;
-- !!!!!!!!!!!!TABLES!!!!!!!!!!!
CREATE TABLE public.coordinator
(
    coordinator_id bigint NOT NULL,
    first_name character varying(50) NOT NULL,
    last_name character varying(50) NOT NULL,
    mobile character varying(20) NOT NULL,
    password character varying(200) NOT NULL,
    password_salt character varying(50) NOT NULL,
    password_hash_algorithm character varying(50) NOT NULL,
    access smallint NOT NULL,
    email character varying(50) NOT NULL,
    address character varying(100) NOT NULL,
    cpr character varying(11) NOT NULL,
    gender character varying(20) NOT NULL,
    PRIMARY KEY (coordinator_id)
);

CREATE TABLE public.coupon
(
    coupon_id bigint NOT NULL,
    description character varying(200) NOT NULL,
    price smallint NOT NULL,
    PRIMARY KEY (coupon_id)
);

CREATE TABLE public.coupon_volunteer
(
    coupon_id bigint,
    volunteer_id bigint,
    used boolean,
    co_vo_id integer NOT NULL,
    PRIMARY KEY (co_vo_id)
);

CREATE TABLE public.logger
(
    logger_id bigint NOT NULL,
    event_type character varying(50) NOT NULL,
    table_name character varying(50) NOT NULL,
    user_role character varying(50) NOT NULL,
    log_date timestamp with time zone NOT NULL,
    PRIMARY KEY (logger_id)
);

CREATE TABLE public.shift
(
    shift_id bigint NOT NULL,
    taken boolean NOT NULL,
    volunteer_id bigint,
    created_at timestamp with time zone,
    task_id bigint NOT NULL,
    locked boolean NOT NULL,
    start_time timestamp with time zone NOT NULL,
    end_time timestamp with time zone NOT NULL,
    PRIMARY KEY (shift_id)
);

CREATE TABLE public.skill
(
    skill_id bigint NOT NULL,
    name character varying(50) NOT NULL,
    PRIMARY KEY (skill_id)
);

CREATE TABLE public.skill_team
(
    skill_id bigint,
    team_id bigint
);

CREATE TABLE public.skill_volunteer
(
    skill_id bigint,
    volunteer_id bigint
);

CREATE TABLE public.task
(
    task_id bigint NOT NULL,
    description character varying(200) NOT NULL,
    PRIMARY KEY (task_id)
);

CREATE TABLE public.team
(
    team_id bigint NOT NULL,
    name character varying(50) NOT NULL,
    contact_name character varying(50) NOT NULL,
    mobile character varying(20) NOT NULL,
    email character varying(50) NOT NULL,
    password character varying(200) NOT NULL,
    password_salt character varying(50) NOT NULL,
    password_hash_algorithm character varying(50) NOT NULL,
    access smallint NOT NULL,
    created_at timestamp without time zone,
    PRIMARY KEY (team_id)
);

CREATE TABLE public.teamtask
(
    teamtask_id bigint NOT NULL,
    description character varying(200) NOT NULL,
    people_needed smallint NOT NULL,
    start_time timestamp without time zone NOT NULL,
    end_time timestamp without time zone NOT NULL,
    taken boolean NOT NULL,
    team_id bigint,
    locked boolean NOT NULL,
    created_at timestamp without time zone,
    PRIMARY KEY (teamtask_id)
);

CREATE TABLE public.volunteer
(
    volunteer_id bigint NOT NULL,
    first_name character varying(50) NOT NULL,
    last_name character varying(50) NOT NULL,
    mobile character varying(20) NOT NULL,
    password character varying(200) NOT NULL,
    password_salt character varying(50) NOT NULL,
    password_hash_algorithm character varying(50) NOT NULL,
    access smallint NOT NULL,
    created_at timestamp with time zone,
    email character varying(50) NOT NULL,
    address character varying(100) NOT NULL,
    cpr character varying(11) NOT NULL,
    gender character varying(20) NOT NULL,
    PRIMARY KEY (volunteer_id)
);

-- !!!!!!!!!!!!FOREIGN KEYS!!!!!!!!!!!
ALTER TABLE public.coupon_volunteer
    ADD FOREIGN KEY (coupon_id)
    REFERENCES public.coupon (coupon_id)
    NOT VALID;


ALTER TABLE public.coupon_volunteer
    ADD FOREIGN KEY (volunteer_id)
    REFERENCES public.volunteer (volunteer_id)
    NOT VALID;


ALTER TABLE public.shift
    ADD FOREIGN KEY (task_id)
    REFERENCES public.task (task_id)
    NOT VALID;


ALTER TABLE public.shift
    ADD FOREIGN KEY (volunteer_id)
    REFERENCES public.volunteer (volunteer_id)
    NOT VALID;


ALTER TABLE public.skill_team
    ADD FOREIGN KEY (skill_id)
    REFERENCES public.skill (skill_id)
    NOT VALID;


ALTER TABLE public.skill_team
    ADD FOREIGN KEY (team_id)
    REFERENCES public.team (team_id)
    NOT VALID;


ALTER TABLE public.skill_volunteer
    ADD FOREIGN KEY (skill_id)
    REFERENCES public.skill (skill_id)
    NOT VALID;


ALTER TABLE public.skill_volunteer
    ADD FOREIGN KEY (volunteer_id)
    REFERENCES public.volunteer (volunteer_id)
    NOT VALID;


ALTER TABLE public.teamtask
    ADD FOREIGN KEY (team_id)
    REFERENCES public.team (team_id)
    NOT VALID;


-- !!!!!!!!!!!!FUNCTIONS!!!!!!!!!!!
CREATE OR REPLACE FUNCTION public.check_login(
	_email character varying,
	pw character varying)
    RETURNS integer
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
AS $BODY$
DECLARE salted varchar;
BEGIN
	IF EXISTS
		(SELECT * 
		 FROM volunteer
		 WHERE email = _email) THEN 
			SELECT password_salt 
			FROM volunteer
			WHERE email = _email
			INTO salted;
			IF (crypt(pw, salted) = (SELECT password FROM volunteer WHERE email = _email)) THEN
				RETURN (SELECT access FROM volunteer WHERE email = _email);
			ELSE
				RAISE EXCEPTION 'Forkert login';
			END IF;
	END IF;
	IF EXISTS
		(SELECT * 
		 FROM coordinator
		 WHERE email = _email) THEN 
			SELECT password_salt 
			FROM coordinator
			WHERE email = _email
			INTO salted;
			IF (crypt(pw, salted) = (SELECT password FROM coordinator WHERE email = _email)) THEN
				RETURN (SELECT access FROM coordinator WHERE email = _email);
			ELSE
				RAISE EXCEPTION 'Forkert login';
			END IF;
	END IF;
	IF EXISTS
		(SELECT * 
		 FROM team
		 WHERE email = _email) THEN 
			SELECT password_salt 
			FROM team
			WHERE email = _email
			INTO salted;
			IF (crypt(pw, salted) = (SELECT password FROM team WHERE email = _email)) THEN
				RETURN (SELECT access FROM team WHERE email = _email);
			ELSE
				RAISE EXCEPTION 'Forkert login 1';
			END IF;
		ELSE
			RAISE EXCEPTION 'Forkert login';
	END IF;
END
$BODY$;

-- !!!!!!!!!!!!PROCEDURES!!!!!!!!!!!
CREATE OR REPLACE PROCEDURE public.add_coordinator(
	firstname text,
	lastname text,
	mobil text,
	_email text,
	_address text,
	_gender text,
	_cpr text,
	pass text)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE
salt text;
BEGIN 
	IF EXISTS (SELECT FROM team WHERE email = _email) THEN
		RAISE EXCEPTION 'Denne email er allerede i brug: %', _email;
	ELSE
		IF EXISTS (SELECT FROM volunteer WHERE email = _email) THEN
			RAISE EXCEPTION 'Denne email er allerede i brug: %', _email;
		ELSE
			IF EXISTS (SELECT FROM coordinator WHERE email = _email) THEN
				RAISE EXCEPTION 'Denne email er allerede i brug: %', _email;
			ELSE
				SELECT gen_salt('md5') into salt;
				INSERT INTO coordinator (first_name, last_name, mobile, password, password_salt, password_hash_algorithm, email, address, cpr, gender) 
					VALUES (firstname, lastname, mobil, crypt(pass, salt), salt, 'md5', _email, _address, _cpr, _gender);
			END IF;
		END IF;
	END IF;
END;
$BODY$;

CREATE OR REPLACE PROCEDURE public.add_coupon(
	_description text,
	_price integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    INSERT INTO coupon (description, price) 
        VALUES (_description, _price); 
END;
$BODY$;

CREATE OR REPLACE PROCEDURE public.add_shift(
	start_t timestamp with time zone,
	end_t timestamp with time zone,
	taskid integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
	IF EXISTS (SELECT task_id FROM task WHERE task_id = taskid) THEN
		INSERT INTO shift (start_time, end_time, task_id)
			VALUES (start_t, end_t, taskid);
	ELSE
		RAISE EXCEPTION 'Fejl i oprettelse. Dette opgave findes ikke: %', taskid;
	END IF;
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.add_skill(
	_name text)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    INSERT INTO skill (name) 
        VALUES (_name);
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.add_task(
	start_t timestamp without time zone,
	end_t timestamp without time zone,
	_description text,
	_number_of_shifts integer)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE 
_id int;
counter int := 0;
BEGIN 
   	INSERT INTO task (description)
	VALUES 
  		(_description) 
	RETURNING task_id INTO _id;
	
	while counter < _number_of_shifts loop
      call add_shift(start_t, end_t, _id);
	  counter := counter + 1;
   end loop;
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.add_team(
	_name text,
	_contact_name text,
	_mobile text,
	_email text,
	pass text)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE
salt text;
BEGIN 
	IF EXISTS (SELECT FROM team WHERE email = _email) THEN
		RAISE EXCEPTION 'Denne email er allerede i brug: %', _email;
	ELSE
		IF EXISTS (SELECT FROM volunteer WHERE email = _email) THEN
			RAISE EXCEPTION 'Denne email er allerede i brug: %', _email;
		ELSE
			IF EXISTS (SELECT FROM coordinator WHERE email = _email) THEN
				RAISE EXCEPTION 'Denne email er allerede i brug: %', _email;
			ELSE
				SELECT gen_salt('md5') into salt;
				INSERT INTO team (name, contact_name, mobile, password, password_salt, password_hash_algorithm, email) 
					VALUES (_name, _contact_name, _mobile, crypt(pass, salt), salt, 'md5', _email);
			END IF;
		END IF;
	END IF;
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.add_teamtask(
	_description text,
	_people_needed integer,
	start_t timestamp without time zone,
	end_t timestamp without time zone)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    INSERT INTO teamtask (description, people_needed, start_time, end_time) 
        VALUES (_description, _people_needed, start_t, end_t);
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.add_volunteer(
	firstname text,
	lastname text,
	mobil text,
	_email text,
	_address text,
	_gender text,
	_cpr text,
	pass text)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE
salt text;
BEGIN 
	IF EXISTS (SELECT FROM team WHERE email = _email) THEN
		RAISE EXCEPTION 'Denne email er allerede i brug: %', _email;
	ELSE
		IF EXISTS (SELECT FROM volunteer WHERE email = _email) THEN
			RAISE EXCEPTION 'Denne email er allerede i brug: %', _email;
		ELSE
			IF EXISTS (SELECT FROM coordinator WHERE email = _email) THEN
				RAISE EXCEPTION 'Denne email er allerede i brug: %', _email;
			ELSE
				SELECT gen_salt('md5') into salt;
				INSERT INTO volunteer (first_name, last_name, mobile, password, password_salt, password_hash_algorithm, email, address, cpr, gender) 
					VALUES (firstname, lastname, mobil, crypt(pass, salt), salt, 'md5', _email, _address, _cpr, _gender);
			END IF;
		END IF;
	END IF;
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.assign_shift(
	vol integer,
	shi integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
	IF EXISTS (SELECT volunteer_id FROM volunteer v WHERE v.volunteer_id = vol) THEN
		IF EXISTS (SELECT shift_id FROM shift s WHERE s.shift_id = shi) THEN
			UPDATE shift
				SET volunteer_id = vol,
					taken = true
				WHERE shift_id = shi;
		ELSE
			RAISE EXCEPTION 'Shift findes ikke: %', shi;
		END IF;
	ELSE
		RAISE EXCEPTION 'Volunteer findes ikke: %', vol;
	END IF;
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.assign_skill(
	_volunteer integer,
	_skill integer,
	_type text)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
	IF EXISTS (SELECT skill_id FROM skill s WHERE s.skill_id = _skill) THEN
		IF _type = 'team' THEN
			IF EXISTS (SELECT team_id FROM team t WHERE t.team_id = _volunteer) THEN
				INSERT INTO skill_team (skill_id, team_id)
					VALUES (_skill, _volunteer);
			ELSE
				RAISE EXCEPTION 'Team findes ikke: %', _volunteer;
			END IF;
		ELSE 
			IF _type = 'volunteer' THEN
				IF EXISTS (SELECT volunteer_id FROM volunteer v WHERE v.volunteer_id = _volunteer) THEN
					INSERT INTO skill_volunteer (skill_id, volunteer_id)
						VALUES (_skill, _volunteer);
				ELSE
					RAISE EXCEPTION 'Volunteer findes ikke: %', _volunteer;
				END IF;
			ELSE
				RAISE EXCEPTION 'Type a frivillig findes ikke';
			END IF;
		END IF;
	ELSE
		RAISE EXCEPTION 'Skill findes ikke: %', _skill;
	END IF;
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.assign_teamtask(
	teamid integer,
	taskid integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
	IF EXISTS (SELECT team_id FROM team t WHERE t.team_id = teamid) THEN
		IF EXISTS (SELECT teamtask_id, team_id FROM teamtask tt WHERE tt.teamtask_id = taskid AND tt.taken = false) THEN
			UPDATE teamtask
				SET team_id = teamid,
					taken = true
				WHERE teamtask_id = taskid;
		ELSE
			RAISE EXCEPTION 'TeamTask % findes ikke eller TeamTask allerede taget', taskid;
		END IF;
	ELSE
		RAISE EXCEPTION 'Team: % findes ikke', teamid;
	END IF;
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.buy_coupon(
	vol integer,
	coup integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
	IF EXISTS (SELECT volunteer_id FROM volunteer v WHERE v.volunteer_id = vol) THEN
		IF EXISTS (SELECT coupon_id FROM coupon c WHERE c.coupon_id = coup) THEN
			INSERT INTO coupon_volunteer (coupon_id, volunteer_id)
				VALUES (coup, vol);
		ELSE
			RAISE EXCEPTION 'Coupon findes ikke: %', shi;
		END IF;
	ELSE
		RAISE EXCEPTION 'Volunteer findes ikke: %', vol;
	END IF;
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.deassign_shift(
	vol integer,
	shi integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
	IF EXISTS (SELECT volunteer_id FROM volunteer v WHERE v.volunteer_id = vol) THEN
		IF EXISTS (SELECT shift_id FROM shift s WHERE s.shift_id = shi) THEN
			IF EXISTS (SELECT shift_id, volunteer_id FROM shift s WHERE s.shift_id = shi AND s.volunteer_id = vol) THEN
			UPDATE shift
				SET volunteer_id = null,
					taken = false
				WHERE shift_id = shi;
			ELSE 
				RAISE EXCEPTION 'Du har ikke denne shift';
			END IF;
		ELSE
			RAISE EXCEPTION 'Shift findes ikke: %', shi;
		END IF;
	ELSE
		RAISE EXCEPTION 'Volunteer findes ikke: %', vol;
	END IF;
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.deassign_skill(
	vol integer,
	ski integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
	IF EXISTS (SELECT volunteer_id FROM volunteer v WHERE v.volunteer_id = vol) THEN
		IF EXISTS (SELECT skill_id FROM skill s WHERE s.skill_id = ski) THEN
			IF EXISTS (SELECT skill_id, volunteer_id FROM skill_volunteer s WHERE s.skill_id = ski AND s.volunteer_id = vol) THEN
			DELETE FROM skill_volunteer
				WHERE skill_id = ski;
			ELSE 
				RAISE EXCEPTION 'Du har ikke denne skill';
			END IF;
		ELSE
			RAISE EXCEPTION 'Skill findes ikke: %', ski;
		END IF;
	ELSE
		RAISE EXCEPTION 'Volunteer findes ikke: %', vol;
	END IF;
END
$BODY$;


CREATE OR REPLACE PROCEDURE public.deassign_teamtask(
	teamid integer,
	taskid integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
	IF EXISTS (SELECT team_id FROM team t WHERE t.team_id = teamid) THEN
		IF EXISTS (SELECT teamtask_id, team_id FROM teamtask tt WHERE tt.teamtask_id = taskid AND tt.team_id = teamid) THEN
			UPDATE teamtask
				SET team_id = null,
					taken = false
				WHERE teamtask_id = taskid;
		ELSE
			RAISE EXCEPTION 'TeamTask % findes ikke eller TeamTask ikke taget af dig', taskid;
		END IF;
	ELSE
		RAISE EXCEPTION 'Team: % findes ikke', teamid;
	END IF;
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.use_coupon(
    vol integer,
    coup integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    IF EXISTS (SELECT * FROM coupon_volunteer cv WHERE cv.coupon_id = coup AND cv.volunteer_id = vol) THEN
        UPDATE
            coupon_volunteer
        SET
            used = true
        WHERE
            co_vo_id IN ( SELECT co_vo_id FROM coupon_volunteer WHERE coupon_id = coup and volunteer_id = vol LIMIT 1 FOR UPDATE );
    ELSE
        RAISE EXCEPTION 'Relation findes ikke mellem volunteer og coupon';
    END IF;
END;
$BODY$;

CREATE OR REPLACE PROCEDURE public.unlock_teamtask(
    teamtaskid bigint)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    UPDATE teamtask
    SET locked = false
    
    WHERE teamtask_id = teamtaskid;
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.unlock_task(
    taskid bigint)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    UPDATE shift
    SET locked = false
    
    WHERE task_id = taskid;
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.unlock_shift(
    shiftid bigint)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    UPDATE shift
    SET locked = false
    
    WHERE shift_id = shiftid;
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.lock_teamtask(
    teamtaskid bigint)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    UPDATE teamtask
    SET locked = true
    
    WHERE teamtask_id = teamtaskid;
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.lock_task(
    taskid bigint)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    UPDATE shift
    SET locked = true
    
    WHERE task_id = taskid;
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.lock_shift(
    shiftid bigint)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    UPDATE shift
    SET locked = true
    
    WHERE shift_id = shiftid;
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.edit_volunteer(
    id integer,
    firstname text,
    lastname text,
    _mobile text,
    _email text,
    _address text,
    _cpr text,
    _gender text)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    UPDATE volunteer
    SET first_name = firstname,
    last_name = lastname,
    mobile = _mobile,
    email = _email,
    address = _address,
    cpr = _cpr,
    gender = _gender
    
    WHERE volunteer_id = id;
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.edit_team(
    id integer,
    _name text,
    _contact_name text,
    _mobile text,
    _email text)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    UPDATE team
    SET name = _name,
    contact_name = _contact_name,
    mobile = _mobile,
    email = _email
    
    WHERE team_id = id;
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.edit_skill(
    id integer,
    _name text)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    UPDATE skill
    SET name = _name
  
    WHERE skill_id = id;
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.edit_coupon(
    id integer,
    _description text,
    _price integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    UPDATE coupon
    SET description = _description,
    price = _price
    
    WHERE coupon_id = id;
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.edit_coordinator(
    id integer,
    firstname text,
    lastname text,
    _mobile text,
    _email text,
    _address text,
    _cpr text,
    _gender text)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    UPDATE coordinator
    SET first_name = firstname,
    last_name = lastname,
    mobile = _mobile,
    email = _email,
    address = _address,
    cpr = _cpr,
    gender = _gender
    
    WHERE coordinator_id = id;
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.delete_volunteer(
    id integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    DELETE FROM volunteer WHERE volunteer_id = id; 
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.delete_teamtask(
    id integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    DELETE FROM teamtask WHERE teamtask_id = id; 
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.delete_team(
    id integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    DELETE FROM team WHERE team_id = id; 
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.delete_task(
    id integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    CALL delete_shifttask(id);
    DELETE FROM task WHERE task_id = id; 
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.delete_skill(
    id integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    DELETE FROM skill WHERE skill_id = id; 
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.delete_shifttask(
    id integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    DELETE FROM shift WHERE task_id = id; 
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.delete_shift(
    id integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    DELETE FROM shift WHERE shift_id = id; 
END
$BODY$;

CREATE OR REPLACE PROCEDURE public.delete_coupon(
    id integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    DELETE FROM coupon WHERE coupon_id = id; 
END
$BODY$;

-- !!!!!!!!!!!!VIEWS!!!!!!!!!!!



CREATE OR REPLACE VIEW public.all_coordinators
 AS
 SELECT coordinator.coordinator_id,
    coordinator.first_name,
    coordinator.last_name,
    coordinator.mobile,
    coordinator.access,
    coordinator.email,
    coordinator.address,
    coordinator.cpr,
    coordinator.gender
   FROM coordinator;

ALTER TABLE public.all_coordinators
    OWNER TO postgres;



CREATE OR REPLACE VIEW public.all_coupons
 AS
 SELECT coupon.coupon_id,
    coupon.description,
    coupon.price
   FROM coupon;

ALTER TABLE public.all_coupons
    OWNER TO postgres;



CREATE OR REPLACE VIEW public.all_shifts
 AS
 SELECT s.shift_id,
    s.start_time,
    s.end_time,
    s.taken,
    s.created_at,
    s.locked,
    v.volunteer_id,
    v.first_name,
    v.last_name,
    v.mobile,
    v.access,
    v.email,
    v.address,
    v.gender,
    t.task_id,
    t.description
   FROM shift s
     LEFT JOIN volunteer v ON v.volunteer_id = s.volunteer_id
     LEFT JOIN task t ON t.task_id = s.task_id;

ALTER TABLE public.all_shifts
    OWNER TO postgres;


CREATE OR REPLACE VIEW public.all_skills
 AS
 SELECT u.skill_id,
    u.name,
    u.team_id,
    u.contact_name,
    u.mobile,
    u.email,
    u.access,
    u.volunteer_id,
    u.first_name,
    u.last_name,
    u.vmobile,
    u.vemail,
    u.address,
    u.cpr,
    u.gender
   FROM ( SELECT s.skill_id,
            s.name,
            t.team_id,
            t.contact_name,
            t.mobile,
            t.email,
            t.access,
            NULL::bigint AS volunteer_id,
            NULL::character varying AS first_name,
            NULL::character varying AS last_name,
            NULL::character varying AS vmobile,
            NULL::character varying AS vemail,
            NULL::character varying AS address,
            NULL::character varying AS cpr,
            NULL::character varying AS gender
           FROM skill s
             LEFT JOIN skill_team st ON st.skill_id = s.skill_id
             LEFT JOIN team t ON t.team_id = st.team_id
        UNION ALL
         SELECT s.skill_id,
            s.name,
            NULL::bigint AS task_id,
            NULL::character varying AS contact_name,
            NULL::character varying AS mobile,
            NULL::character varying AS email,
            NULL::smallint AS access,
            v.volunteer_id,
            v.first_name,
            v.last_name,
            v.mobile,
            v.email,
            v.address,
            v.cpr,
            v.gender
           FROM skill s
             LEFT JOIN skill_volunteer sv ON sv.skill_id = s.skill_id
             LEFT JOIN volunteer v ON v.volunteer_id = sv.volunteer_id) u;

ALTER TABLE public.all_skills
    OWNER TO postgres;



CREATE OR REPLACE VIEW public.all_tasks
 AS
 SELECT t.task_id,
    t.description,
    s.shift_id,
    s.start_time,
    s.end_time,
    s.taken,
    s.volunteer_id,
    s.locked
   FROM task t
     LEFT JOIN shift s ON s.task_id = t.task_id;

ALTER TABLE public.all_tasks
    OWNER TO postgres;


CREATE OR REPLACE VIEW public.all_teams
 AS
 SELECT u.team_id,
    u.name,
    u.contact_name,
    u.mobile,
    u.email,
    u.password,
    u.password_salt,
    u.password_hash_algorithm,
    u.access,
    u.teamtask_id,
    u.description,
    u.people_needed,
    u.start_time,
    u.end_time,
    u.taken,
    u.locked,
    u.skill_id,
    u.skillname
   FROM ( SELECT t.team_id,
            t.name,
            t.contact_name,
            t.mobile,
            t.email,
            t.password,
            t.password_salt,
            t.password_hash_algorithm,
            t.access,
            tt.teamtask_id,
            tt.description,
            tt.people_needed,
            tt.start_time,
            tt.end_time,
            tt.taken,
            tt.locked,
            NULL::bigint AS skill_id,
            NULL::character varying AS skillname
           FROM team t
             LEFT JOIN teamtask tt ON tt.team_id = t.team_id
        UNION ALL
         SELECT t.team_id,
            t.name,
            t.contact_name,
            t.mobile,
            t.email,
            t.password,
            t.password_salt,
            t.password_hash_algorithm,
            t.access,
            NULL::bigint AS teamtask_id,
            NULL::character varying AS description,
            NULL::smallint AS people_needed,
            NULL::timestamp without time zone AS start_time,
            NULL::timestamp without time zone AS end_time,
            NULL::boolean AS taken,
            NULL::boolean AS locked,
            s.skill_id,
            s.name AS skillname
           FROM team t
             LEFT JOIN skill_team st ON st.team_id = t.team_id
             LEFT JOIN skill s ON s.skill_id = st.skill_id) u;

ALTER TABLE public.all_teams
    OWNER TO postgres;


CREATE OR REPLACE VIEW public.all_teamtasks
 AS
 SELECT tt.teamtask_id,
    tt.description,
    tt.people_needed,
    tt.start_time,
    tt.end_time,
    tt.taken,
    tt.team_id,
    tt.locked,
    tt.created_at,
    t.name,
    t.contact_name,
    t.mobile,
    t.email,
    t.access
   FROM teamtask tt
     LEFT JOIN team t ON t.team_id = tt.team_id;

ALTER TABLE public.all_teamtasks
    OWNER TO postgres;



CREATE OR REPLACE VIEW public.all_volunteers
 AS
 SELECT u.volunteer_id,
    u.first_name,
    u.last_name,
    u.mobile,
    u.access,
    u.email,
    u.address,
    u.cpr,
    u.gender,
    u.shift_id,
    u.start_time,
    u.end_time,
    u.taken,
    u.task_id,
    u.locked,
    u.coupon_id,
    u.description,
    u.price,
    u.used,
    u.skill_id,
    u.name
   FROM ( SELECT v.volunteer_id,
            v.first_name,
            v.last_name,
            v.mobile,
            v.access,
            v.email,
            v.address,
            v.cpr,
            v.gender,
            NULL::bigint AS shift_id,
            NULL::timestamp without time zone AS start_time,
            NULL::timestamp without time zone AS end_time,
            NULL::boolean AS taken,
            NULL::boolean AS locked,
            NULL::bigint AS task_id,
            c.coupon_id,
            c.description,
            c.price,
            cv.used,
            NULL::bigint AS skill_id,
            NULL::text AS name
           FROM volunteer v
             JOIN coupon_volunteer cv ON cv.volunteer_id = v.volunteer_id
             JOIN coupon c ON c.coupon_id = cv.coupon_id
        UNION ALL
         SELECT v.volunteer_id,
            v.first_name,
            v.last_name,
            v.mobile,
            v.access,
            v.email,
            v.address,
            v.cpr,
            v.gender,
            s.shift_id,
            s.start_time,
            s.end_time,
            s.taken,
            s.locked,
            s.task_id,
            NULL::bigint AS coupon_id,
            NULL::character varying AS description,
            NULL::smallint AS price,
            NULL::boolean AS used,
            NULL::bigint AS skill_id,
            NULL::text AS name
           FROM volunteer v
             JOIN shift s ON s.volunteer_id = v.volunteer_id
        UNION ALL
         SELECT v.volunteer_id,
            v.first_name,
            v.last_name,
            v.mobile,
            v.access,
            v.email,
            v.address,
            v.cpr,
            v.gender,
            NULL::bigint AS shift_id,
            NULL::timestamp without time zone AS start_time,
            NULL::timestamp without time zone AS end_time,
            NULL::boolean AS taken,
            NULL::boolean AS locked,
            NULL::bigint AS task_id,
            NULL::bigint AS coupon_id,
            NULL::character varying AS description,
            NULL::smallint AS price,
            NULL::boolean AS used,
            sk.skill_id,
            sk.name
           FROM volunteer v
             LEFT JOIN skill_volunteer skv ON skv.volunteer_id = v.volunteer_id
             LEFT JOIN skill sk ON sk.skill_id = skv.skill_id) u;

ALTER TABLE public.all_volunteers
    OWNER TO postgres;


END;