SELECT DISTINCT
	star_finds.sfno AS find_id,
	star_finds.star_contextfindmaterialid AS find_material_uri
 FROM
	star_finds
WHERE
	star_finds.star_contextfindmaterialid <> ''
