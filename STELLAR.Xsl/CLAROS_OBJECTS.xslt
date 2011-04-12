<?xml version="1.0" encoding="UTF-8"?>
<!--
	CLAROS_OBJECTS - experimental template to assess how well CLAROS templates fit 
	into STELLAR approach.	Created by Ceri Binding, University of Glamorgan
	
	Revision History:
	=============================================================================== 
	Ref	Date		   Who	Description
	=============================================================================== 
	1.0	2010-11-09	CFB	Initially created template library
-->

<xsl:stylesheet version="2.0" exclude-result-prefixes="xsl" xml:space="preserve"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  
	xmlns:xsd="http://www.w3.org/2001/XMLSchema#"
	xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#" 
	xmlns:rdfs="http://www.w3.org/2000/01/rdf-schema#" 
	xmlns:ecrm="http://purl.org/NET/crm-owl#" 
	xmlns:geo="http://www.w3.org/2003/01/geo/wgs84_pos#"
	xmlns:claros="http://purl.org/NET/Claros/vocab#">
	
	<xsl:output method="xml" version="1.0" encoding="UTF-8" indent="yes"/>
	<xsl:preserve-space elements="*"/>
	
	<xsl:include href="CLAROS.xslt"/>	
	
	<xsl:template match="/">
		<rdf:RDF>
			<xsl:for-each select="//row">		
				<xsl:call-template name="CLAROS_OBJECT">
					<xsl:with-param name="OBJECT_URI" select="col[@name = 'object_uri']"/>
					<xsl:with-param name="OBJECT_ID" select="col[@name = 'object_id']"/>
					<xsl:with-param name="OBJECT_LABEL" select="col[@name = 'object_label']"/>
					<xsl:with-param name="OBJECT_TITLE" select="col[@name = 'object_title']"/>
					<xsl:with-param name="PERIOD_BEGIN" select="col[@name = 'period_begin']"/>
					<xsl:with-param name="PERIOD_END" select="col[@name = 'period_end']"/>
					<xsl:with-param name="OBJECT_TYPE" select="col[@name = 'object_type']"/>
					<xsl:with-param name="OBJECT_TYPE_URI" select="col[@name = 'object_type_uri']"/>
					<xsl:with-param name="THUMB_URI" select="col[@name = 'thumb_uri']"/>
					<xsl:with-param name="THUMB_LABEL" select="col[@name = 'thumb_label']"/>
					<xsl:with-param name="IMAGE_URI" select="col[@name = 'image_uri']"/>
					<xsl:with-param name="IMAGE_LABEL" select="col[@name = 'image_label']"/>
					<xsl:with-param name="PAGE_URI" select="col[@name = 'page_uri']"/>
					<xsl:with-param name="REFERENCE" select="col[@name = 'reference']"/>
				</xsl:call-template>
			</xsl:for-each>
		</rdf:RDF>
	</xsl:template>
	
	<!--
	expects input data file in format as returned by CSV2XML.xslt, and columns may be in any order, most are optional:
	<?xml version="1.0" encoding="UTF-8"?>
	<data>
		<row id="1">
			<col name="object_uri">http://xyz/1</col>
			<col name="object_id">ABC.1</col>
			<col name="object_label">Greek urn (fragments)</col>
			<col name="object_title">Greek urn fragments</col>
			<col name="object_type">urn</col>
		</row>
		<row id="2">
			<col name="object_uri">http://xyz/2</col>
			<col name="object_id">ABC.2</col>
			<col name="object_label">Roman coin</col>
			<col name="object_title">Vespasian coin</col>
			<col name="object_type">coin</col>
		</row>
	etc.
	-->	
</xsl:stylesheet>
