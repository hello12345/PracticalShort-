DECLARE @StartDate DATE = '2023-11-25';
DECLARE @EndDate DATE = '2024-12-31';

WITH DateSequence AS (
    SELECT TOP (DATEDIFF(DAY, @StartDate, @EndDate) + 1)
        DateValue = DATEADD(DAY, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) - 1, @StartDate)
    FROM master.dbo.spt_values
)
SELECT COUNT(*) AS SundayWithEvenDateInstances
FROM DateSequence
WHERE DATEPART(WEEKDAY, DateValue) = 1  -- Sunday
    AND DAY(DateValue) % 2 = 0;  -- Even date