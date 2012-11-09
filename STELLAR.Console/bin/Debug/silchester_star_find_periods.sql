SELECT DISTINCT
	star_finds.sfno AS find_id,
	star_finds.star_minyear || '/' || star_finds.star_maxyear AS production_period
 FROM
	star_finds
WHERE
	star_finds.star_minyear <> 0
