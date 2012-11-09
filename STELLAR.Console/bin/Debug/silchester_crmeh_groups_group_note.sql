SELECT
	objects.object AS group_id,
	objects.title AS group_note
FROM objects
WHERE
	objects.title <> ''
UNION
SELECT
	objects.object AS group_id,
	objects.notes AS group_note
FROM objects
WHERE
	objects.notes <> '';