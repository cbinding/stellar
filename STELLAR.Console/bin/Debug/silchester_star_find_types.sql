SELECT DISTINCT
	star_finds.sfno AS find_id,
	star_finds.star_contextfindtypeid AS find_type_uri
 FROM
	star_finds
WHERE
	star_finds.star_contextfindtypeid <> ''
