    class Query
    {
        public static readonly enum queries
        {
            login = "SELECT employee_id FROM Employee WHERE name = @id",

            //View all approved hours for an employee, or view employee info 
            view_hours = "SELECT Employee.name, Hours.number_of_hours FROM Hours, Employee_Hours, Employee WHERE Employee.employee_id = Employee_Hours.employee_id AND Employee_Hours.hours_id = Hours.hours_id AND Hours.approved = TRUE AND Employe.employee_id = @id",
            view_employee = "SELECT * FROM Employee WHERE employee_id = @id",

            //Get quarterly report 
            quarter_report = "SELECT * FROM Hours",

            //Manager puts in or removes an employee 
            new_employee = "INSERT INTO Employee(employee_id, name, type, email, wage) VALUES (@id, @name, @type, @email, @wage)",
            remove_employee = "DELETE FROM Employee WHERE employee_id = @id",

            //Employee Logs hours 
            log_hours = "INSERT INTO Hours(hours_id, charge_date, week_number, approved, billable, number_of_hours) VALUES (@hours_id, @charge_date, @week_number, @approved, @billable, @hours)",
            prev_hours = "SELECT Hours.week_number, Hours.number_of_hours FROM Hours, Employee_Hours WHERE Employee_Hours.employee_id = @id",
            pending = "SELECT * FROM Hours WHERE approved = 'unapproved'"
            
            //Employee changes personal email
            change_email = "UPDATE TABLE Employee SET email = @email WHERE employee_id = @id",

            //Manage approves/declines hours
            approve_hours = "UPDATE TABLE Hours SET approved = TRUE WHERE hours_id = @hours_id",
            decline_hours = "UPDATE TABLE Hours SET approved = FALSE WHERE hours_id = @hours_id",

            //Manager changes employee info 
            change_type = "UPDATE TABLE Employee SET type = @type WHERE employee_id = @id",
            change_wage = "UPDATE TABLE Employee SET wage = @wage WHERE employee_id = @id"

            
        }; 
    }
