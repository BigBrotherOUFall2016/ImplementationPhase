CREATE TABLE Employee(
  employee_id VARCHAR(15) NOT NULL,
  name VARCHAR(20) NOT NULL,
  type VARCHAR(20) NOT NULL,
  email VARCHAR(40) NOT NULL,
  wage NUMBER(9, 2) NOT NULL,

  PRIMARY KEY(employee_id)
);

CREATE TABLE Employee_Hours(
  employee_id VARCHAR(15) NOT NULL,
  hours_id VARCHAR(15) NOT NULL,

  PRIMARY KEY(employee_id, hours_id),
  FOREIGN KEY (employee_id) REFERENCES Employee(employee_id)
);

CREATE TABLE Hours(
  hours_id VARCHAR(15) NOT NULL,
  charge_date VARCHAR(10) NOT NULL,
  week_number NUMBER(2) NOT NULL,
  approved NUMBER(1) NOT NULL,
  billable NUMBER(1) NOT NULL,
  number_of_hours NUMBER(4, 2) NOT NULL,

  PRIMARY KEY (hours_id),
  FOREIGN KEY (hours_id) REFERENCES Employee_Hours(hours_id)
);

CREATE TABLE Works(
  employee_id VARCHAR(15) NOT NULL,
  hours_id VARCHAR(15) NOT NULL,

  PRIMARY KEY(employee_id),
  FOREIGN KEY (employee_id, hours_id) REFERENCES
    Employee(employee_id),
    Employee_Hours(hours_id)
);

CREATE TABLE Logs(
  employee_id VARCHAR(15) NOT NULL,
  hours_id VARCHAR(15) NOT NULL,

  PRIMARY KEY(employee_id),
  FOREIGN KEY (employee_id, hours_id) REFERENCES
    Employee_Hours(employee_id, hours_id)
);
