INSERT INTO service.plans (plan_name, monthly_fee)
VALUES 
    ('Basic Plan', 10.00),
    ('Standard Plan', 25.00),
    ('Premium Plan', 50.00);

INSERT INTO service.devices (device_name, device_type)
VALUES 
    ('Router Model A', 'Router'),
    ('Router Model B', 'Router'),
    ('Modem Model X', 'Modem'),
    ('Modem Model Y', 'Modem');

INSERT INTO service.abonents (first_name, last_name, phone, email, address, plan_id, device_id)
VALUES 
    ('John', 'Doe', '123-456-7890', 'john.doe@example.com', '123 Main St, City', 1, 1),
    ('Jane', 'Smith', '234-567-8901', 'jane.smith@example.com', '456 Elm St, Town', 2, 2),
    ('Alice', 'Johnson', '345-678-9012', 'alice.johnson@example.com', '789 Oak St, Village', 3, 3),
    ('Bob', 'Williams', '456-789-0123', 'bob.williams@example.com', '101 Pine St, Hamlet', 2, 4);

INSERT INTO customer_service.support_tickets (abonent_id, issue_description, ticket_status, creation_date)
VALUES 
    (1, 'Connection issue', 'Open', '2025-02-01'),
    (2, 'Slow internet speed', 'In Progress', '2025-02-01'),
    (3, 'Device not working', 'Closed', '2025-01-28'),
    (4, 'Wi-Fi signal weak', 'Open', '2025-02-02');

INSERT INTO customer_service.payment_history (abonent_id, amount, payment_date, payment_method)
VALUES 
    (1, 10.00, '2025-02-01', 'Credit Card'),
    (2, 25.00, '2025-01-30', 'Bank Transfer'),
    (3, 50.00, '2025-01-25', 'PayPal'),
    (4, 25.00, '2025-02-01', 'Credit Card');

INSERT INTO customer_service.technicians (first_name, last_name, email, phone, active)
VALUES 
    ('Steve', 'Green', 'steve.green@example.com', '987-654-3210', 1),
    ('Karen', 'Brown', 'karen.brown@example.com', '876-543-2109', 1),
    ('Paul', 'White', 'paul.white@example.com', '765-432-1098', 0);

INSERT INTO customer_service.technician_assignments (ticket_id, technician_id, assigned_date)
VALUES 
    (1, 1, '2025-02-01'),
    (2, 2, '2025-02-01'),
    (4, 1, '2025-02-02');

