SELECT
	objects.object AS group_id,
	olinks.object AS within_group_id
FROM objects
INNER JOIN olinks 
ON	olinks.member = 'O' || objects.object;