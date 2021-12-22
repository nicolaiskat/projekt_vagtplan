BEGIN;

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

END;