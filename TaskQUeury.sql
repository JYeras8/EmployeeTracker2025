DELETE FROM Task;

-- If you want to update existing rows to have specific values:
UPDATE Task
SET TaskStartDate = '2025-02-25',
    TaskDeliveryDate = '2026-03-25';

    UPDATE Task
SET TaskState = (SELECT Id FROM TaskState WHERE StateName = 'New');