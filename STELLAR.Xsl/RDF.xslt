<?xml version="1.0" encoding="UTF-8"?>
<!--STELLAR template library-->
<xsl:stylesheet version="2.0" exclude-result-prefixes="xsl"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:xsd="http://www.w3.org/2001/XMLSchema#"
	xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#" 
	xmlns:rdfs="http://www.w3.org/2000/01/rdf-schema#">
	
	<xsl:output method="xml" version="1.0" encoding="UTF-8" indent="yes"/>
	<xsl:preserve-space elements="*"/>	
	
	<!--template conditionally creates rdf:about attribute only if URI is passed in-->
	<xsl:template name="RDF_ABOUT">
		<xsl:param name="URI"/>
		
		<xsl:if test="normalize-space($URI) != ''">
			<xsl:attribute name="rdf:about"><xsl:value-of select="normalize-space($URI)"/></xsl:attribute>			
		</xsl:if>
	</xsl:template>
		
	<!--template conditionally creates rdf:value property only if VAL is passed in-->
	<xsl:template name="RDF_VALUE">
		<xsl:param name="VAL"/>
		
		<xsl:if test="normalize-space($VAL) != ''">
			<rdf:value><xsl:value-of select="normalize-space($VAL)"/></rdf:value>			
		</xsl:if>
	</xsl:template>
	
	<!--template conditionally creates rdfs:label property only if LBL is passed in-->
	<xsl:template name="RDFS_LABEL">
		<xsl:param name="LBL"/>
		<xsl:param name="LANGUAGE"/>
		
		<xsl:if test="normalize-space($LBL) != ''">
			<rdfs:label>
				<xsl:if test="normalize-space($LANGUAGE) != ''">
					<xsl:attribute name="xml:lang">
						<xsl:value-of select="normalize-space($LANGUAGE)"/>
					</xsl:attribute>
				</xsl:if>
				<xsl:value-of select="normalize-space($LBL)"/>
			</rdfs:label>			
		</xsl:if>
	</xsl:template>	
	
	<!--template conditionally creates rdf:resource attribute only if URI is passed in-->
	<xsl:template name="RDF_RESOURCE">
		<xsl:param name="URI"/>
		
		<xsl:if test="normalize-space($URI) != ''">
			<xsl:attribute name="rdf:resource"><xsl:value-of select="normalize-space($URI)"/></xsl:attribute>			
		</xsl:if>
	</xsl:template>
	
</xsl:stylesheet>
