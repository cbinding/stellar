SELECT
	finds.sfno AS find_id,
	finds.start_date || '/' || finds.end_date AS production_period
FROM finds
WHERE rec_type <> 'SA'
AND finds.start_date <> 0 
AND finds.end_date <> 0 
UNION SELECT
	finds.sfno AS find_id,
	finds.date_term AS production_period
FROM finds
WHERE rec_type <> 'SA'
AND finds.date_term <> ''
UNION SELECT
	finds.sfno AS find_id,
	finds.spotdate AS production_period
FROM finds
WHERE rec_type <> 'SA'
AND finds.spotdate <> '';