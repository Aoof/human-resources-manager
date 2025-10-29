CREATE TABLE [dbo].[Employee] (
    [Id]        INT           NOT NULL,
    [FirstName] VARCHAR (50)  NOT NULL,
    [LastName]  VARCHAR (50)  NOT NULL,
    [Email]     VARCHAR (100) NOT NULL,
    [SSN]       CHAR (11)     NOT NULL,
    [HireDate]  DATETIME      DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Email] ASC)
);

INSERT INTO [dbo].[Employee] ([Id], [FirstName], [LastName], [Email], [SSN], [HireDate]) VALUES
(1, 'John', 'Doe', 'john.doe@example.com', '123-456-789', '2024-11-15'),
(2, 'Jane', 'Smith', 'jane.smith@example.com', '234-567-890', '2025-02-10'),
(3, 'Michael', 'Johnson', 'michael.johnson@example.com', '345-678-901', '2024-08-22'),
(4, 'Emily', 'Davis', 'emily.davis@example.com', '456-789-012', '2025-05-05'),
(5, 'David', 'Wilson', 'david.wilson@example.com', '567-890-123', '2024-12-01'),
(6, 'Sarah', 'Brown', 'sarah.brown@example.com', '678-901-234', '2025-03-18'),
(7, 'Robert', 'Miller', 'robert.miller@example.com', '789-012-345', '2024-09-30'),
(8, 'Lisa', 'Garcia', 'lisa.garcia@example.com', '890-123-456', '2025-01-25'),
(9, 'James', 'Martinez', 'james.martinez@example.com', '901-234-567', '2024-07-14'),
(10, 'Anna', 'Lopez', 'anna.lopez@example.com', '012-345-678', '2025-04-09');

