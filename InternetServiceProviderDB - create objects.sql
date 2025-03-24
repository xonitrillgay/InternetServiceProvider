CREATE SCHEMA service;
go

CREATE SCHEMA customer_service;
go

-- create tables
CREATE TABLE service.plans (
	plan_id INT IDENTITY (1, 1) PRIMARY KEY,
	plan_name VARCHAR (255) NOT NULL,
	monthly_fee DECIMAL (10, 2) NOT NULL
);

CREATE TABLE service.devices (
	device_id INT IDENTITY (1, 1) PRIMARY KEY,
	device_name VARCHAR (255) NOT NULL,
	device_type VARCHAR (255) NOT NULL
);

CREATE TABLE service.abonents (
	abonent_id INT IDENTITY (1, 1) PRIMARY KEY,
	first_name VARCHAR (255) NOT NULL,
	last_name VARCHAR (255) NOT NULL,
	phone VARCHAR (25),
	email VARCHAR (255) NOT NULL,
	address VARCHAR (255) NOT NULL,
	plan_id INT NOT NULL,
	device_id INT,
	FOREIGN KEY (plan_id) REFERENCES service.plans (plan_id) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (device_id) REFERENCES service.devices (device_id) ON DELETE SET NULL ON UPDATE CASCADE
);

CREATE TABLE customer_service.support_tickets (
	ticket_id INT IDENTITY (1, 1) PRIMARY KEY,
	abonent_id INT NOT NULL,
	issue_description VARCHAR (255) NOT NULL,
	ticket_status VARCHAR (50) NOT NULL, -- Possible values: 'Open', 'In Progress', 'Closed'
	creation_date DATE NOT NULL,
	closure_date DATE,
	FOREIGN KEY (abonent_id) REFERENCES service.abonents (abonent_id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE customer_service.payment_history (
	payment_id INT IDENTITY (1, 1) PRIMARY KEY,
	abonent_id INT NOT NULL,
	amount DECIMAL (10, 2) NOT NULL,
	payment_date DATE NOT NULL,
	payment_method VARCHAR (50) NOT NULL, -- Example: 'Credit Card', 'Bank Transfer', etc.
	FOREIGN KEY (abonent_id) REFERENCES service.abonents (abonent_id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE customer_service.technicians (
	technician_id INT IDENTITY (1, 1) PRIMARY KEY,
	first_name VARCHAR (50) NOT NULL,
	last_name VARCHAR (50) NOT NULL,
	email VARCHAR (255) NOT NULL UNIQUE,
	phone VARCHAR (25),
	active TINYINT NOT NULL
);

CREATE TABLE customer_service.technician_assignments (
	assignment_id INT IDENTITY (1, 1) PRIMARY KEY,
	ticket_id INT NOT NULL,
	technician_id INT NOT NULL,
	assigned_date DATE NOT NULL,
	completion_date DATE,
	FOREIGN KEY (ticket_id) REFERENCES customer_service.support_tickets (ticket_id) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (technician_id) REFERENCES customer_service.technicians (technician_id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE customer_service.abonent_feedback (
	feedback_id INT IDENTITY (1, 1) PRIMARY KEY,
	ticket_id INT NOT NULL,
	abonent_id INT NOT NULL,
	feedback_text VARCHAR (255),
	rating INT CHECK (rating BETWEEN 1 AND 5),
	FOREIGN KEY (ticket_id) REFERENCES customer_service.support_tickets (ticket_id) ON DELETE NO ACTION ON UPDATE CASCADE,
	FOREIGN KEY (abonent_id) REFERENCES service.abonents (abonent_id) ON DELETE NO ACTION ON UPDATE CASCADE
);

CREATE TABLE register (
	id_user int identity(1,1) not null,
	login_user varchar(50) not null,
	password_user varchar(50) not null
);