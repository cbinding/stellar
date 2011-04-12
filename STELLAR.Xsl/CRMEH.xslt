<?xml version="1.0" encoding="UTF-8"?>
<!--
STELLAR template library for creating CRMEH entities and relationships
Created by Ceri Binding, University of Glamorgan

Revision History:
=============================================================================== 
Ref		Date		   Who	Description
=============================================================================== 
1.0		2010-11-03	CFB	Initially created template library
2.0		2010-11-08	CFB	Based on CRMEH v2.0 - http://purl.org/CRMEH/v2.0
2.1		2010-03-03	CFB	CRMEH_INVESTIGATION template added, within_site_id changed to within_investigation_id
-->
<xsl:stylesheet version="2.0" exclude-result-prefixes="xsl ext"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:xsd="http://www.w3.org/2001/XMLSchema#"
	xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#" 
	xmlns:rdfs="http://www.w3.org/2000/01/rdf-schema#" 
	xmlns:ecrm="http://erlangen-crm.org/101001/"
	xmlns:crmeh="http://purl.org/crmeh#"
	xmlns:ext="stellar:ext">
	
	<xsl:import href="ECRM.xslt"/>
	
	<xsl:output method="xml" version="1.0" encoding="UTF-8" indent="yes"/>
	<xsl:preserve-space elements="*"/>	

	<!--template creates EHProject-->
	<xsl:template name="CRMEH_EHE0001">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0001_EHProject>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0001_EHProject>
	</xsl:template>
	
	<!--template creates ArchaeologicalSite-->
	<xsl:template name="CRMEH_EHE0002">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0002_ArchaeologicalSite>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0002_ArchaeologicalSite>
	</xsl:template>
	
	<!--template creates AreaOfInvestigation-->
	<xsl:template name="CRMEH_EHE0003">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0003_AreaOfInvestigation>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0003_AreaOfInvestigation>
	</xsl:template>

	<!--template creates SiteSubDivision-->
	<xsl:template name="CRMEH_EHE0004">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0004_SiteSubDivision>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0004_SiteSubDivision>
	</xsl:template>

	<!--template creates Group-->
	<xsl:template name="CRMEH_EHE0005">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0005_Group>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0005_Group>
	</xsl:template>
	
	<!--template creates GroupStuff-->
	<xsl:template name="CRMEH_EHE0006">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0006_GroupStuff>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0006_GroupStuff>
	</xsl:template>

	<!--template creates Context-->
	<xsl:template name="CRMEH_EHE0007">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0007_Context>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0007_Context>
	</xsl:template>
	
	<!--template creates ContextStuff-->
	<xsl:template name="CRMEH_EHE0008">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0008_ContextStuff>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0008_ContextStuff>
	</xsl:template>
	
	<!--template creates ContextFind-->
	<xsl:template name="CRMEH_EHE0009">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0009_ContextFind>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0009_ContextFind>
	</xsl:template>
	
	<!--template creates BulkFind-->
	<xsl:template name="CRMEH_EHE0010">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0010_BulkFind>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0010_BulkFind>
	</xsl:template>
	
	<!--template creates GroupEventRecord-->
	<xsl:template name="CRMEH_EHE0011">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0011_GroupEventRecord>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0011_GroupEventRecord>
	</xsl:template>

	<!--template creates ContextEventRecord-->
	<xsl:template name="CRMEH_EHE0012">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0012_ContextEventRecord>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0012_ContextEventRecord>
	</xsl:template>

	<!--template creates ContextSheet-->
	<xsl:template name="CRMEH_EHE0013">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0013_ContextSheet>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0013_ContextSheet>
	</xsl:template>

	<!--template creates ContextFindProductionEventRecord-->
	<xsl:template name="CRMEH_EHE0014">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0013_ContextFindProductionEventRecord>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0013_ContextFindProductionEventRecord>
	</xsl:template>
	
	<!--template creates ContextFindUseEventRecord-->
	<xsl:template name="CRMEH_EHE0015">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0015_ContextFindUseEventRecord>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0015_ContextFindUseEventRecord>
	</xsl:template>

	<!--template creates RecordDrawing-->
	<xsl:template name="CRMEH_EHE0016">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0016_RecordDrawing>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0016_RecordDrawing>
	</xsl:template>
	
	<!--template creates RecordPhotograph-->
	<xsl:template name="CRMEH_EHE0017">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0017_RecordPhotograph>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0017_RecordPhotograph>
	</xsl:template>

	<!--template creates ContextSample-->
	<xsl:template name="CRMEH_EHE0018">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0018_ContextSample>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0018_ContextSample>
	</xsl:template>

	<!--template creates AreaOfInvestigationDepiction-->
	<xsl:template name="CRMEH_EHE0019">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0019_AreaOfInvestigationDepiction>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0019_AreaOfInvestigationDepiction>
	</xsl:template>	
	
	<!--template creates EHProjectTimespan-->
	<xsl:template name="CRMEH_EHE0021">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0021_EHProjectTimespan>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0021_EHProjectTimespan>
	</xsl:template>
	
	<!--template creates ContextDepiction-->
	<xsl:template name="CRMEH_EHE0022">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0022_ContextDepiction>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0022_ContextDepiction>
	</xsl:template>		
	
	<!--template creates ContextEventTimespan-->
	<xsl:template name="CRMEH_EHE0025">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0025_ContextEventTimespan>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0025_ContextEventTimespan>
	</xsl:template>

	<!--template creates ContextEventTimespanAppellation-->
	<xsl:template name="CRMEH_EHE0026">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0026_ContextEventTimespanAppellation>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0026_ContextEventTimespanAppellation>		
	</xsl:template>

	<!--template creates ContextFindConditionAssessmentTimespan-->
	<xsl:template name="CRMEH_EHE0027">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0027_ContextFindConditionAssessmentTimespan>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0027_ContextFindConditionAssessmentTimespan>
	</xsl:template>

	<!--template creates ContextFindConditionAssessmentEventType-->
	<xsl:template name="CRMEH_EHE0028">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>

		<crmeh:EHE0028_ContextFindConditionAssessmentEventType>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0028_ContextFindConditionAssessmentEventType>		
	</xsl:template>
	
	<!--template creates ContextFindConditionState-->
	<xsl:template name="CRMEH_EHE0029">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0029_ContextFindConditionState>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0029_ContextFindConditionState>
	</xsl:template>

	<!--template creates ContextFindMaterial-->
	<xsl:template name="CRMEH_EHE0030">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0030_ContextFindMaterial>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0030_ContextFindMaterial>		
	</xsl:template>

	<!--template creates ContextFindMeasurement-->
	<xsl:template name="CRMEH_EHE0031">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0031_ContextFindMeasurement>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0031_ContextFindMeasurement>
	</xsl:template>
	
	<!--template creates ContextFindMeasurementEventTimespan-->
	<xsl:template name="CRMEH_EHE0032">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0032_ContextFindMeasurementEventTimespan>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0032_ContextFindMeasurementEventTimespan>
	</xsl:template>

	<!--template creates ContextFindMeasurementEventType-->
	<xsl:template name="CRMEH_EHE0033">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0033_ContextFindMeasurementEventType>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0033_ContextFindMeasurementEventType>		
	</xsl:template>

	<!--template creates ContextFindMeasurementUnit-->
	<xsl:template name="CRMEH_EHE0034">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0034_ContextFindMeasurementUnit>	
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0034_ContextFindMeasurementUnit>		
	</xsl:template>	
	
	<!--template creates ContextFindProductionEventTimespan-->
	<xsl:template name="CRMEH_EHE0038">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0038_ContextFindProductionEventTimespan>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0038_ContextFindProductionEventTimespan>
	</xsl:template>
	
	<!--template creates ContextFindProductionEventTimespanAppellation-->
	<xsl:template name="CRMEH_EHE0039">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0039_ContextFindProductionEventTimespanAppellation>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0039_ContextFindProductionEventTimespanAppellation>		
	</xsl:template>

	<!--template creates ContextFindTreatmentLocation-->
	<xsl:template name="CRMEH_EHE0040">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0040_ContextFindTreatmentLocation>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0040_ContextFindTreatmentLocation>
	</xsl:template>
	
	<!--template creates ContextFindTreatmentProcedure-->
	<xsl:template name="CRMEH_EHE0041">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0041_ContextFindTreatmentProcedure>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0041_ContextFindTreatmentProcedure>
	</xsl:template>
	
	<!--template creates ContextFindTreatmentType-->
	<xsl:template name="CRMEH_EHE0042">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0042_ContextFindTreatmentType>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0042_ContextFindTreatmentType>		
	</xsl:template>

	<!--template creates ContextFindUID-->
	<xsl:template name="CRMEH_EHE0043">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0043_ContextFindUID>		
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0043_ContextFindUID>		
	</xsl:template>	

	<!--template creates ContextRecord-->
	<xsl:template name="CRMEH_EHE0048">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0048_ContextRecord>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0048_ContextRecord>
	</xsl:template>
	
	<!--template creates ContextSampleMeasurement-->
	<xsl:template name="CRMEH_EHE0049">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0049_ContextSampleMeasurement>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0049_ContextSampleMeasurement>
	</xsl:template>

	<!--template creates ContextSampleMeasurementType-->
	<xsl:template name="CRMEH_EHE0050">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0050_ContextSampleMeasurementType>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0050_ContextSampleMeasurementType>		
	</xsl:template>

	<!--template creates ContextSampleMeasurementUnit-->
	<xsl:template name="CRMEH_EHE0051">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0051_ContextSampleMeasurementUnit>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0051_ContextSampleMeasurementUnit>		
	</xsl:template>	

	<!--template creates ContextSampleType-->
	<xsl:template name="CRMEH_EHE0053">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0053_ContextSampleType>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0053_ContextSampleType>		
	</xsl:template>
	
	<!--template creates ContextStuffMeasurement-->
	<xsl:template name="CRMEH_EHE0054">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0054_ContextStuffMeasurement>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0054_ContextStuffMeasurement>
	</xsl:template>
	
	<!--template creates ContextStuffMeasurementEventTimespan-->
	<xsl:template name="CRMEH_EHE0055">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0055_ContextStuffMeasurementEventTimespan>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0055_ContextStuffMeasurementEventTimespan>
	</xsl:template>
	
	<!--template creates ContextStuffMeasurementEventType-->
	<xsl:template name="CRMEH_EHE0056">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0056_ContextStuffMeasurementEventType>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0056_ContextStuffMeasurementEventType>		
	</xsl:template>

	<!--template creates ContextStuffMeasurementUnit-->
	<xsl:template name="CRMEH_EHE0057">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0057_ContextStuffMeasurementUnit>	
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0057_ContextStuffMeasurementUnit>		
	</xsl:template>	
	
	<!--template creates ContextUID-->
	<xsl:template name="CRMEH_EHE0061">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0061_ContextUID>		
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0061_ContextUID>		
	</xsl:template>
	
	<!--template creates FlotationSample-->
	<xsl:template name="CRMEH_EHE0062">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0062_FlotationSample>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0062_FlotationSample>
	</xsl:template>
	
	<!--template creates FlotationSampleResidue-->
	<xsl:template name="CRMEH_EHE0063">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0063_FlotationSampleResidue>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0063_FlotationSampleResidue>
	</xsl:template>

	<!--template creates FlotationSampleResidueMeasurement-->
	<xsl:template name="CRMEH_EHE0064">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0064_FlotationSampleResidueMeasurement>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0064_FlotationSampleResidueMeasurement>
	</xsl:template>

	<!--template creates FlotationSampleResidueMeasurementUnit-->
	<xsl:template name="CRMEH_EHE0065">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0065_FlotationSampleResidueMeasurementUnit>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0065_FlotationSampleResidueMeasurementUnit>		
	</xsl:template>	

	<!--template creates FlotationSampleResidueType-->
	<xsl:template name="CRMEH_EHE0067">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0067_FlotationSampleResidueType>	
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0067_FlotationSampleResidueType>		
	</xsl:template>
	
	<!--template creates GroupEventTimespan-->
	<xsl:template name="CRMEH_EHE0070">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0070_GroupEventTimespan>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0070_GroupEventTimespan>
	</xsl:template>
	
	<!--template creates GroupEventTimespanAppellation-->
	<xsl:template name="CRMEH_EHE0071">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
				
		<crmeh:EHE0071_GroupEventTimespanAppellation>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0071_GroupEventTimespanAppellation>		
	</xsl:template>
	
	<!--template creates GroupEventType-->
	<xsl:template name="CRMEH_EHE0072">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0072_GroupEventType>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0072_GroupEventType>		
	</xsl:template>
	
	<!--template creates GroupingPhasingProcedure-->
	<xsl:template name="CRMEH_EHE0073">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0073_GroupingPhasingProcedure>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0073_GroupingPhasingProcedure>
	</xsl:template>
	
	<!--template creates IdentifiedFeature-->
	<xsl:template name="CRMEH_EHE0074">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>		
		
		<crmeh:EHE0074_IdentifiedProcedure>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0074_IdentifiedProcedure>
	</xsl:template>
	
	<!--template creates IdentifiedFeatureDepiction-->
	<xsl:template name="CRMEH_EHE0075">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>		
		
		<crmeh:EHE0075_IdentifiedFeatureDepiction>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0075_IdentifiedFeatureDepiction>
	</xsl:template>
	
	<!--template creates ProjectDesign-->
	<xsl:template name="CRMEH_EHE0076">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>		
				
		<crmeh:EHE0076_ProjectDesign>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0076_ProjectDesign>
	</xsl:template>

	<!--template creates ProjectTeamMember-->
	<xsl:template name="CRMEH_EHE0077">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>	
				
		<crmeh:EHE0077_ProjectTeamMember>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0077_ProjectTeamMember>
	</xsl:template>

	<!--template creates ProjectTeamMemberRole-->
	<xsl:template name="CRMEH_EHE0078">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>	
				
		<crmeh:EHE0078_ProjectTeamMemberRole>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0078_ProjectTeamMemberRole>
	</xsl:template>

	<!--template creates RecordDrawingReferenceType-->
	<xsl:template name="CRMEH_EHE0081">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>	
				
		<crmeh:EHE0081_RecordDrawingReferenceType>	
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0081_RecordDrawingReferenceType>		
	</xsl:template>
	
	<!--template creates RecordDrawingSheet-->
	<xsl:template name="CRMEH_EHE0082">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>	
		
		<crmeh:EHE0082_RecordDrawingSheet>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0082_RecordDrawingSheet>
	</xsl:template>	

	<!--template creates RecordPhotographReferenceType-->
	<xsl:template name="CRMEH_EHE0085">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>	
				
		<crmeh:EHE0085_RecordPhotographReferenceType>	
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0085_RecordPhotographReferenceType>		
	</xsl:template>

	<!--template creates ResponsibleAgent-->
	<xsl:template name="CRMEH_EHE0086">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>	
				
		<crmeh:EHE0086_ResponsibleAgent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0086_ResponsibleAgent>
	</xsl:template>

	<!--template creates SiteSubDivisionAppellation-->
	<xsl:template name="CRMEH_EHE0087">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>	
		
		<crmeh:EHE0087_SiteSubDivisionAppellation>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0087_SiteSubDivisionAppellation>		
	</xsl:template>
	
	<!--template creates SiteSubDivisionDepiction-->
	<xsl:template name="CRMEH_EHE0088">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>	
		
		<crmeh:EHE0088_SiteSubDivisionDepiction>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0088_SiteSubDivisionDepiction>
	</xsl:template>
	
	<!--template creates StorageLocation-->
	<xsl:template name="CRMEH_EHE0089">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>	
				
		<crmeh:EHE0089_StorageLocation>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0089_StorageLocation>
	</xsl:template>

	<!--template creates SurveyDataset-->
	<xsl:template name="CRMEH_EHE0090">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>	
		
		<crmeh:EHE0090_SurveyDataset>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0090_SurveyDataset>
	</xsl:template>	

	<!--template creates GroupUID-->
	<xsl:template name="CRMEH_EHE0092">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>	
		
		<crmeh:EHE0092_GroupUID>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0092_GroupUID>		
	</xsl:template>
	
	<!--template creates GroupDepiction-->
	<xsl:template name="CRMEH_EHE0093">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>	
		
		<crmeh:EHE0093_GroupDepiction>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0093_GroupDepiction>
	</xsl:template>
	
	<!--template creates FlotationSampleResidueMeasurementType-->
	<xsl:template name="CRMEH_EHE0094">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>	
				
		<crmeh:EHE0094_FlotationSampleResidueMeasurementType>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0094_FlotationSampleResidueMeasurementType>		
	</xsl:template>

	<!--template creates ContextFindProductionEventLocation-->
	<xsl:template name="CRMEH_EHE0095">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>	
		
		<crmeh:EHE0095_ContextFindProductionEventLocation>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0095_ContextFindProductionEventLocation>
	</xsl:template>
	
	<!--template creates ContextFindGeneralUse-->
	<xsl:template name="CRMEH_EHE0096">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
						
		<crmeh:EHE0096_ContextFindGeneralUse>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0096_ContextFindGeneralUse>		
	</xsl:template>
	
	<!--template creates ContextFindIntendedUse-->
	<xsl:template name="CRMEH_EHE0097">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0097_ContextFindIntendedUse>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0097_ContextFindIntendedUse>		
	</xsl:template>

	<!--template creates ContextExcavationEventTimespan-->
	<xsl:template name="CRMEH_EHE0098">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0098_ContextExcavationEventTimespan>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0098_ContextExcavationEventTimespan>
	</xsl:template>

	<!--template creates ContextFindUseEventTimespan-->
	<xsl:template name="CRMEH_EHE0099">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0099_ContextFindUseEventTimespan>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0099_ContextFindUseEventTimespan>
	</xsl:template>
	
	<!--template creates ContextSamplingEventType-->
	<xsl:template name="CRMEH_EHE0100">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0100_ContextSamplingEventType>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0100_ContextSamplingEventType>		
	</xsl:template>
	
	<!--template creates ArchaeologicalPeriod-->
	<xsl:template name="CRMEH_EHE0101">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0101_ArchaeologicalPeriod>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0101_ArchaeologicalPeriod>
	</xsl:template>
	
	<!--template creates ArchaeologicalPeriodType-->
	<xsl:template name="CRMEH_EHE0102">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0102_ArchaeologicalPeriodType>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0102_ArchaeologicalPeriodType>		
	</xsl:template>
	
	<!--template creates ArchaeologicalPeriodTimespan-->
	<xsl:template name="CRMEH_EHE0103">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE0103_ArchaeologicalPeriodTimespan>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE0103_ArchaeologicalPeriodTimespan>
	</xsl:template>	

	<!--template creates ContextEvent-->
	<xsl:template name="CRMEH_EHE1001">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE1001_ContextEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE1001_ContextEvent>
	</xsl:template>	
	
	<!--template creates ContextFindProductionEvent-->
	<xsl:template name="CRMEH_EHE1002">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE1002_ContextFindProductionEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE1002_ContextFindProductionEvent>
	</xsl:template>	

	<!--template creates GroupEvent-->
	<xsl:template name="CRMEH_EHE1003">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE1003_GroupEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE1003_GroupEvent>
	</xsl:template>	

	<!--template creates ContextFindDepositionEvent-->
	<xsl:template name="CRMEH_EHE1004">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE1004_ContextFindDepositionEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE1004_ContextFindDepositionEvent>
	</xsl:template>	

	<!--template creates ContextFindUseEvent-->
	<xsl:template name="CRMEH_EHE1005">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE1005_ContextFindUseEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE1005_ContextFindUseEvent>
	</xsl:template>	

	<!--template creates ContextExcavationEvent-->
	<xsl:template name="CRMEH_EHE2001">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE2001_ContextExcavationEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE2001_ContextExcavationEvent>
	</xsl:template>	

	<!--template creates ContextFindClassificationEvent-->
	<xsl:template name="CRMEH_EHE2002">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE2002_ContextFindClassificationEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE2002_ContextFindClassificationEvent>
	</xsl:template>	

	<!--template creates ContextFindTreatmentEvent-->
	<xsl:template name="CRMEH_EHE2003">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE2003_ContextFindTreatmentEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE2003_ContextFindTreatmentEvent>
	</xsl:template>
	
	<!--template creates GroupingPhasingEvent-->
	<xsl:template name="CRMEH_EHE2004">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE2004_GroupingPhasingEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE2004_GroupingPhasingEvent>
	</xsl:template>

	<!--template creates ContextFindDatingEvent-->
	<xsl:template name="CRMEH_EHE2005">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE2005_ContextFindDatingEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE2005_ContextFindDatingEvent>
	</xsl:template>
	
	<!--template creates ContextSamplingEvent-->
	<xsl:template name="CRMEH_EHE2006">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE2006_ContextSamplingEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE2006_ContextSamplingEvent>
	</xsl:template>

	<!--template creates SurveyEvent-->
	<xsl:template name="CRMEH_EHE2007">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE2007_SurveyEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE2007_SurveyEvent>
	</xsl:template>
	
	<!--template creates ProcessSurveyDatasetEvent-->
	<xsl:template name="CRMEH_EHE2008">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE2008_ProcessSurveyDatasetEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE2008_ProcessSurveyDatasetEvent>
	</xsl:template>
	
	<!--template creates TransferObjectEvent-->
	<xsl:template name="CRMEH_EHE2009">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE2009_TransferObjectEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE2009_TransferObjectEvent>
	</xsl:template>

	<!--template creates DepictionEvent-->
	<xsl:template name="CRMEH_EHE2010">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE2010_DepictionEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE2010_DepictionEvent>
	</xsl:template>
	
	<!--template creates BulkFindItemRemovalEvent-->
	<xsl:template name="CRMEH_EHE2011">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE2011_BulkFindItemRemovalEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE2011_BulkFindItemRemovalEvent>
	</xsl:template>

	<!--template creates ContextFindConditionAssessmentEvent-->
	<xsl:template name="CRMEH_EHE2012">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE2012_ContextFindConditionAssessmentEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE2012_ContextFindConditionAssessmentEvent>
	</xsl:template>

	<!--template creates ContextFindIdentifierAssignmentEvent-->
	<xsl:template name="CRMEH_EHE2013">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE2013_ContextFindIdentifierAssignmentEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE2013_ContextFindIdentifierAssignmentEvent>
	</xsl:template>

	<!--template creates ContextFindUseAssessmentEvent-->
	<xsl:template name="CRMEH_EHE2014">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE2014_ContextFindUseAssessmentEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE2014_ContextFindUseAssessmentEvent>
	</xsl:template>
	
	<!--template creates ContextSampleProcessingEvent-->
	<xsl:template name="CRMEH_EHE2015">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE2015_ContextSampleProcessingEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE2015_ContextSampleProcessingEvent>
	</xsl:template>

	<!--template creates ContextStuffMeasurementEvent-->
	<xsl:template name="CRMEH_EHE2016">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE2016_ContextStuffMeasurementEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE2016_ContextStuffMeasurementEvent>
	</xsl:template>
	
	<!--template creates FlotationSampleProcessingEvent-->
	<xsl:template name="CRMEH_EHE2017">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE2017_FlotationSampleProcessingEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE2017_FlotationSampleProcessingEvent>
	</xsl:template>

	<!--template creates FlotationSampleResidueProcessingEvent-->
	<xsl:template name="CRMEH_EHE2018">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE2018_FlotationSampleResidueProcessingEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE2018_FlotationSampleResidueProcessingEvent>
	</xsl:template>

	<!--template creates SimpleNameAssignmentEvent-->
	<xsl:template name="CRMEH_EHE2019">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE2019_SimpleNameAssignmentEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE2019_SimpleNameAssignmentEvent>
	</xsl:template>
	
	<!--template creates ContextFindMeasurementEvent-->
	<xsl:template name="CRMEH_EHE2020">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<crmeh:EHE2020_ContextFindMeasurementEvent>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE2020_ContextFindMeasurementEvent>
	</xsl:template>
	
	<!--template creates BulkFindAssessment-->
	<xsl:template name="CRMEH_EHE2021">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
				
		<crmeh:EHE2021_BulkFindAssessment>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</crmeh:EHE2021_BulkFindAssessment>
	</xsl:template>
	
	<!--template implements property X EHP1F.is_trace_of Y & Y EHP1B.has_trace X-->
	<xsl:template name="CRMEH_X_EHP1_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<crmeh:EHP1_is_trace_of rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<crmeh:EHP1i_has_trace rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<crmeh:EHP1_is_trace_of>
						<xsl:copy-of select="$Y_OBJ"/>
					</crmeh:EHP1_is_trace_of>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X EHP2F.is_trace_of_type Y & Y EHP2B.is_type_of X-->
	<xsl:template name="CRMEH_X_EHP2_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<crmeh:EHP2_is_trace_of_type rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<crmeh:EHP2i_is_type_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<crmeh:EHP2_is_trace_of_type>
						<xsl:copy-of select="$Y_OBJ"/>
					</crmeh:EHP2_is_trace_of_type>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>		
	</xsl:template>


	<!--template implements property X EHP3F.occupied Y & Y EHP3B.was_occupied_by X-->
	<xsl:template name="CRMEH_X_EHP3_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<crmeh:EHP3_occupied rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<crmeh:EHP3i_was_occupied_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<crmeh:EHP3_occupied>
						<xsl:copy-of select="$Y_OBJ"/>
					</crmeh:EHP3_occupied>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>	
	</xsl:template>

	<!--template implements property X EHP4F.depicts Y & Y EHP4B.is_depicted_by X-->
	<xsl:template name="CRMEH_X_EHP4_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<crmeh:EHP4_depicts rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<crmeh:EHP4i_is_depicted_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<crmeh:EHP4_depicts>
						<xsl:copy-of select="$Y_OBJ"/>
					</crmeh:EHP4_depicts>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>	
	</xsl:template>

	<!--template implements extension property X EXP1F.year_min Y-->
	<xsl:template name="CRMEH_X_EXP1_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_VAL"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<crmeh:EXP1_year_min>	
				<xsl:value-of select="$Y_VAL"/>	
			</crmeh:EXP1_year_min>			
		</rdf:Description>		
	</xsl:template>

	<!--template implements extension property X EXP2F.year_max Y-->
	<xsl:template name="CRMEH_X_EXP2_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_VAL"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<crmeh:EXP2_year_max>	
				<xsl:value-of select="$Y_VAL"/>	
			</crmeh:EXP2_year_max>			
		</rdf:Description>		
	</xsl:template>

	<!--template implements extension property X EXP3F.spatial_x Y-->
	<xsl:template name="CRMEH_X_EXP3_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_VAL"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<crmeh:EXP3_spatial_x>	
				<xsl:value-of select="$Y_VAL"/>	
			</crmeh:EXP3_spatial_x>
		</rdf:Description>
	</xsl:template>

	<!--template implements extension property X EXP4F.spatial_y Y-->
	<xsl:template name="CRMEH_X_EXP4_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_VAL"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<crmeh:EXP4_spatial_y>	
				<xsl:value-of select="$Y_VAL"/>	
			</crmeh:EXP4_spatial_y>
		</rdf:Description>
	</xsl:template>
	
	<!--template implements extension property X EXP5F.spatial_z Y-->
	<xsl:template name="CRMEH_X_EXP5_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_VAL"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<crmeh:EXP5_spatial_z>	
				<xsl:value-of select="$Y_VAL"/>	
			</crmeh:EXP5_spatial_z>
		</rdf:Description>
	</xsl:template>
	
	<!--template implements extension property X EXP10F.is_represented_by Y-->
	<xsl:template name="CRMEH_X_EXP10_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<crmeh:EXP10_is_represented_by rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<crmeh:EHP10i_represents rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<crmeh:EXP10_is_represented_by>
						<xsl:copy-of select="$Y_OBJ"/>
					</crmeh:EXP10_is_represented_by>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	
	<!--template creates a URI of the format {BASE_URI}{TYPE}_{ID}-->
	<xsl:template name="CRMEH_URI">
		<xsl:param name="TYPE"/>
		<xsl:param name="ID"/>
		
		<xsl:value-of select="normalize-space($BASE_URI)"/>
		<xsl:value-of select="normalize-space($TYPE)"/><!--and lowercase - reduce inconsistency?-->
		<!--<xsl:value-of select="escape-html-uri(normalize-space($TYPE))"/>-->
		<xsl:text>_</xsl:text>
		<xsl:value-of select="ext:URLEncode($ID)"/><!--and lowercase - reduce inconsistency?-->
		<!--<xsl:value-of select="escape-html-uri(normalize-space($ID))"/>-->
	</xsl:template>	
	
	
	<!--***NEW TEMPLATES USING OPTIONAL PARAMETERS***-->
	<!--CRMEH_GROUP - new 15/11/10-->
	<xsl:template name="CRMEH_GROUP">
		<xsl:param name="GROUP_ID"/><!--mandatory: group identifier-->
		<xsl:param name="GROUP_NOTE"/><!--optional-->
		<xsl:param name="GROUP_LOCATION"/><!--optional-->	
		<xsl:param name="GROUP_TYPE"/><!--optional-->	
		<xsl:param name="GROUP_TYPE_URI"/><!--optional-->
		<xsl:param name="GROUP_PERIOD"/><!--optional-->
		<xsl:param name="WITHIN_GROUP_ID"/><!--optional (container group)-->
		<xsl:param name="WITHIN_INVESTIGATION_ID"/><!--optional: investigation identifier-->
		<xsl:param name="LANGUAGE"/>		
		
		<!--Create the Group URI-->
		<xsl:variable name="EHE0005_URI">
			<xsl:call-template name="CRMEH_URI">
				<xsl:with-param name="TYPE">EHE0005</xsl:with-param>
				<xsl:with-param name="ID" select="normalize-space($GROUP_ID)"/>
			</xsl:call-template>
		</xsl:variable>
		
		<!--Create the GroupUID URI -->
		<xsl:variable name="EHE0092_URI">
			<xsl:call-template name="CRMEH_URI">
				<xsl:with-param name="TYPE">EHE0092</xsl:with-param>
				<xsl:with-param name="ID" select="normalize-space($GROUP_ID)"/>
			</xsl:call-template>
		</xsl:variable>

		<!--Create the Group Entity-->
		<xsl:call-template name="CRMEH_EHE0005">
			<xsl:with-param name="URI" select="$EHE0005_URI"/>
			<xsl:with-param name="LBL" select="normalize-space($GROUP_ID)"/>
		</xsl:call-template>
		
		<!--Create the GroupUID Entity-->
		<xsl:call-template name="CRMEH_EHE0092">
			<xsl:with-param name="URI" select="$EHE0092_URI"/>
			<xsl:with-param name="VAL" select="normalize-space($GROUP_ID)"/>
		</xsl:call-template>
		
		<!--Group is_identified_by GroupUID-->
		<xsl:call-template name="ECRM_X_P87_Y">
			<xsl:with-param name="X_URI" select="$EHE0005_URI"/>
			<xsl:with-param name="Y_URI" select="$EHE0092_URI"/>
		</xsl:call-template>
		
		<!--GROUP_NOTE-->	
		<xsl:if test="normalize-space($GROUP_NOTE) != ''">
			<xsl:call-template name="ECRM_X_P3_Y">
				<xsl:with-param name="X_URI" select="$EHE0005_URI"/>
				<xsl:with-param name="Y_VAL">
					<xsl:value-of select="$GROUP_NOTE"/>
				</xsl:with-param> 
				<xsl:with-param name="LANGUAGE" select="$LANGUAGE"/>
			</xsl:call-template>
		</xsl:if>		
		
		<!--GROUP_TYPE_URI-->
		<xsl:if test="normalize-space($GROUP_TYPE_URI) != ''">
			<!--Group has_type Type-->
			<xsl:call-template name="ECRM_X_P2_Y">
				<xsl:with-param name="X_URI" select="$EHE0005_URI"/>
				<xsl:with-param name="Y_URI" select="normalize-space($GROUP_TYPE_URI)"/>
			</xsl:call-template>
		</xsl:if>	
			
		<!--GROUP_TYPE-->
		<xsl:if test="normalize-space($GROUP_TYPE) != ''">	
			<!--Create the E55_EHE0005 URI -->
			<xsl:variable name="E55_EHE0005_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">E55_EHE0005</xsl:with-param>
					<xsl:with-param name="ID" select="normalize-space($GROUP_TYPE)"/>
				</xsl:call-template>
			</xsl:variable>
				
			<!--Create the E55_Type Entity-->
			<xsl:call-template name="ECRM_E55">
				<xsl:with-param name="URI" select="$E55_EHE0005_URI"/>
				<xsl:with-param name="LBL" select="normalize-space($GROUP_TYPE)"/>
			</xsl:call-template>
	
			<!--Group has_type Type-->
			<xsl:call-template name="ECRM_X_P2_Y">
				<xsl:with-param name="X_URI" select="$EHE0005_URI"/>
				<xsl:with-param name="Y_URI" select="$E55_EHE0005_URI"/>
			</xsl:call-template>		
		</xsl:if>		
		
		<!--GROUP_LOCATION-->	
		<xsl:if test="normalize-space($GROUP_LOCATION) != ''">
			<!--Create the GroupDepiction URI-->
			<xsl:variable name="EHE0093_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0093</xsl:with-param>
					<xsl:with-param name="ID" select="$GROUP_ID"/>
				</xsl:call-template>
			</xsl:variable>

			<!--Create the GroupDepiction Entity-->
			<xsl:call-template name="CRMEH_EHE0093">
				<xsl:with-param name="URI" select="$EHE0093_URI"/>
				<xsl:with-param name="VAL" select="normalize-space($GROUP_LOCATION)"/>
			</xsl:call-template>

			<!--Group is_identified_by GroupDepiction-->
			<xsl:call-template name="ECRM_X_P87_Y">
				<xsl:with-param name="X_URI" select="$EHE0005_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0093_URI"/>					
			</xsl:call-template>
		</xsl:if>

		
		<!--GROUP_PERIOD-->
		<xsl:if test="normalize-space($GROUP_PERIOD) != ''">
			<!--Create the GroupEvent URI-->
			<xsl:variable name="EHE1003_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE1003</xsl:with-param>
					<xsl:with-param name="ID" select="normalize-space($GROUP_ID)"/>
				</xsl:call-template>
			</xsl:variable>
			
			<!--Create the GroupEventTimespan URI-->
			<xsl:variable name="EHE0070_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0070</xsl:with-param>
					<xsl:with-param name="ID" select="normalize-space($GROUP_ID)"/>
				</xsl:call-template>
			</xsl:variable>
			
			<!--Create the GroupEventTimespanAppellation URI-->
			<xsl:variable name="EHE0071_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0071</xsl:with-param>
					<xsl:with-param name="ID" select="normalize-space($GROUP_ID)"/>
				</xsl:call-template>
			</xsl:variable>
			
			<!--Create the GroupEvent Entity-->
			<xsl:call-template name="CRMEH_EHE1003">
				<xsl:with-param name="URI" select="$EHE1003_URI"/>				
			</xsl:call-template>	
			
			<!--Create the GroupEventTimespan Entity-->
			<xsl:call-template name="CRMEH_EHE0070">
				<xsl:with-param name="URI" select="$EHE0070_URI"/>
			</xsl:call-template>	
			
			<!--Create the GroupEventTimespanAppellation Entity-->
			<xsl:call-template name="CRMEH_EHE0071">
				<xsl:with-param name="URI" select="$EHE0071_URI"/>	
				<xsl:with-param name="VAL" select="$GROUP_PERIOD"/>
			</xsl:call-template>		
			
			<!--GroupEvent took_place_at Group-->
			<xsl:call-template name="ECRM_X_P7_Y">
				<xsl:with-param name="X_URI" select="$EHE1003_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0005_URI"/>
			</xsl:call-template>
			
			<!--GroupEvent has_timespan GroupEventTimespan-->
			<xsl:call-template name="ECRM_X_P4_Y">
				<xsl:with-param name="X_URI" select="$EHE1003_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0070_URI"/>
			</xsl:call-template>
			
			<!--GroupEventTimespan is_identified_by GroupEventTimespanAppellation-->
			<xsl:call-template name="ECRM_X_P1_Y">
				<xsl:with-param name="X_URI" select="$EHE0070_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0071_URI"/>
			</xsl:call-template>
			
			<!--GroupEventTimespan at_some_time_within period-->
			<xsl:call-template name="ECRM_X_P82_Y">
				<xsl:with-param name="X_URI" select="$EHE0070_URI"/>
				<xsl:with-param name="Y_VAL">
					<xsl:value-of select="normalize-space($GROUP_PERIOD)"/>
				</xsl:with-param>
			</xsl:call-template>

		</xsl:if>	
			
		<!--WITHIN_GROUP_ID-->		
		<xsl:if test="normalize-space($WITHIN_GROUP_ID) != ''">
			<!--Create 2nd Group URI-->
			<xsl:variable name="EHE0005_URI2">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0005</xsl:with-param>
					<xsl:with-param name="ID" select="$WITHIN_GROUP_ID"/>
				</xsl:call-template>
			</xsl:variable>
		
			<!--Create 2nd Group Entity-->
			<xsl:call-template name="CRMEH_EHE0005">
				<xsl:with-param name="URI" select="$EHE0005_URI2"/>
			</xsl:call-template>
			
			<!--Group falls_within Group2-->
			<xsl:call-template name="ECRM_X_P89_Y">
				<xsl:with-param name="X_URI" select="$EHE0005_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0005_URI2"/>
			</xsl:call-template>

		</xsl:if><!--end Group falls_within Group-->	
		
		<!--WITHIN_INVESTIGATION_ID-->			
		<xsl:if test="normalize-space($WITHIN_INVESTIGATION_ID) != ''">
		
			<!--Create AreaOfInterest URI-->
			<xsl:variable name="EHE0003_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0003</xsl:with-param>
					<xsl:with-param name="ID" select="$WITHIN_INVESTIGATION_ID"/>
				</xsl:call-template>
			</xsl:variable>
		
			<!--Create AreaOfInterest Entity-->
			<xsl:call-template name="CRMEH_EHE0003">
				<xsl:with-param name="URI" select="$EHE0003_URI"/>
				<xsl:with-param name="LBL" select="normalize-space($WITHIN_INVESTIGATION_ID)"/>
			</xsl:call-template>
			
			<!--Group falls_within AreaOfInterest-->
			<xsl:call-template name="ECRM_X_P89_Y">
				<xsl:with-param name="X_URI" select="$EHE0005_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0003_URI"/>
			</xsl:call-template>

		</xsl:if> <!--end Group falls_within AOI-->

	</xsl:template>	<!--end CRMEH_GROUP-->
	
	<!--CRMEH_CONTEXT - new 15/11/10-->
	<xsl:template name="CRMEH_CONTEXT">
		<xsl:param name="CONTEXT_ID"/><!--mandatory: context identifier-->
		<xsl:param name="CONTEXT_NOTE"/><!--optional-->
		<xsl:param name="CONTEXT_TYPE"/><!--optional-->	
		<xsl:param name="CONTEXT_TYPE_URI"/><!--optional-->	
		<xsl:param name="CONTEXT_LOCATION"/><!--optional-->	
		<xsl:param name="CONTEXT_PERIOD"/><!--optional-->	
		<xsl:param name="WITHIN_CONTEXT_ID"/><!--optional (container context)-->
		<xsl:param name="WITHIN_GROUP_ID"/><!--optional (container group)-->
		<xsl:param name="STRAT_LOWER_ID"/>
		<xsl:param name="STRAT_EQUAL_ID"/>
		<xsl:param name="WITHIN_INVESTIGATION_ID"/><!--optional: investigation identifier-->
		<xsl:param name="LANGUAGE"/>
		
		<!--Create the Context URI-->
		<xsl:variable name="EHE0007_URI">
			<xsl:call-template name="CRMEH_URI">
				<xsl:with-param name="TYPE">EHE0007</xsl:with-param>
				<xsl:with-param name="ID" select="$CONTEXT_ID"/>
			</xsl:call-template>
		</xsl:variable>
		
		<!--Create the ContextUID URI-->
		<xsl:variable name="EHE0061_URI">
			<xsl:call-template name="CRMEH_URI">
				<xsl:with-param name="TYPE">EHE0061</xsl:with-param>
				<xsl:with-param name="ID" select="$CONTEXT_ID"/>
			</xsl:call-template>
		</xsl:variable>

		<!--Create the Context Entity-->
		<xsl:call-template name="CRMEH_EHE0007">
			<xsl:with-param name="URI" select="$EHE0007_URI"/>
			<xsl:with-param name="LBL" select="$CONTEXT_ID"/>
		</xsl:call-template>
		
		<!--Create the ContextUID Entity-->
		<xsl:call-template name="CRMEH_EHE0061">
			<xsl:with-param name="URI" select="$EHE0061_URI"/>
			<xsl:with-param name="VAL" select="$CONTEXT_ID"/>
		</xsl:call-template>	
		
		<!--Context is_identified_by ContextUID-->
		<xsl:call-template name="ECRM_X_P87_Y">
			<xsl:with-param name="X_URI" select="$EHE0007_URI"/>
			<xsl:with-param name="Y_URI" select="$EHE0061_URI"/>
		</xsl:call-template>
		
		<!--CONTEXT_NOTE-->	
		<xsl:if test="normalize-space($CONTEXT_NOTE) != ''">
			<xsl:call-template name="ECRM_X_P3_Y">
				<xsl:with-param name="X_URI" select="$EHE0007_URI"/>
				<xsl:with-param name="Y_VAL">
					<xsl:value-of select="$CONTEXT_NOTE"/>
				</xsl:with-param> 
				<xsl:with-param name="LANGUAGE" select="$LANGUAGE"/>
			</xsl:call-template>
		</xsl:if>	
		
		<!--CONTEXT_TYPE_URI-->
		<xsl:if test="normalize-space($CONTEXT_TYPE_URI) != ''">
			<!--Group has_type Type-->
			<xsl:call-template name="ECRM_X_P2_Y">
				<xsl:with-param name="X_URI" select="$EHE0007_URI"/>
				<xsl:with-param name="Y_URI" select="normalize-space($CONTEXT_TYPE_URI)"/>
			</xsl:call-template>
		</xsl:if>	
		
		<!--CONTEXT_TYPE-->
		<xsl:if test="normalize-space($CONTEXT_TYPE) != ''">	
			<!--Create the E55_EHE0007 URI -->
			<xsl:variable name="E55_EHE0007_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">E55_EHE0007</xsl:with-param>
					<xsl:with-param name="ID" select="normalize-space($CONTEXT_TYPE)"/>
				</xsl:call-template>
			</xsl:variable>
				
			<!--Create the E55_Type Entity-->
			<xsl:call-template name="ECRM_E55">
				<xsl:with-param name="URI" select="$E55_EHE0007_URI"/>
				<xsl:with-param name="LBL" select="normalize-space($CONTEXT_TYPE)"/>
			</xsl:call-template>
	
			<!--Context has_type Type-->
			<xsl:call-template name="ECRM_X_P2_Y">
				<xsl:with-param name="X_URI" select="$EHE0007_URI"/>
				<xsl:with-param name="Y_URI" select="$E55_EHE0007_URI"/>
			</xsl:call-template>		
		</xsl:if>				
		
		<!--CONTEXT_LOCATION-->	
		<xsl:if test="normalize-space($CONTEXT_LOCATION) != ''">
			<!--Create the ContextDepiction URI-->
			<xsl:variable name="EHE0022_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0022</xsl:with-param>
					<xsl:with-param name="ID" select="$CONTEXT_ID"/>
				</xsl:call-template>
			</xsl:variable>

			<!--Create the ContextDepiction Entity-->
			<xsl:call-template name="CRMEH_EHE0022">
				<xsl:with-param name="URI" select="$EHE0022_URI"/>
				<xsl:with-param name="VAL" select="normalize-space($CONTEXT_LOCATION)"/>
			</xsl:call-template>

			<!--Context is_identified_by ContextDepiction-->
			<xsl:call-template name="ECRM_X_P87_Y">
				<xsl:with-param name="X_URI" select="$EHE0007_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0022_URI"/>
			</xsl:call-template>
		</xsl:if>
		
		<!--CONTEXT_PERIOD-->
		<xsl:if test="normalize-space($CONTEXT_PERIOD) != ''">
			<!--Create the ContextEvent URI-->
			<xsl:variable name="EHE1001_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE1001</xsl:with-param>
					<xsl:with-param name="ID" select="normalize-space($CONTEXT_ID)"/>
				</xsl:call-template>
			</xsl:variable>
			
			<!--Create the ContextEventTimespan URI-->
			<xsl:variable name="EHE0025_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0025</xsl:with-param>
					<xsl:with-param name="ID" select="normalize-space($CONTEXT_ID)"/>
				</xsl:call-template>
			</xsl:variable>
			
			<!--Create the ContextEventTimespanAppellation URI-->
			<xsl:variable name="EHE0026_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0026</xsl:with-param>
					<xsl:with-param name="ID" select="normalize-space($CONTEXT_ID)"/>
				</xsl:call-template>
			</xsl:variable>
			
			<!--Create the ContextEvent Entity-->
			<xsl:call-template name="CRMEH_EHE1001">
				<xsl:with-param name="URI" select="$EHE1001_URI"/>				
			</xsl:call-template>	
			
			<!--Create the ContextEventTimespan Entity-->
			<xsl:call-template name="CRMEH_EHE0025">
				<xsl:with-param name="URI" select="$EHE0025_URI"/>				
			</xsl:call-template>	
			
			<!--Create the ContextEventTimespanAppellation Entity-->
			<xsl:call-template name="CRMEH_EHE0026">
				<xsl:with-param name="URI" select="$EHE0026_URI"/>	
				<xsl:with-param name="VAL" select="$CONTEXT_PERIOD"/>					
			</xsl:call-template>		
			
			<!--ContextEvent took_place_at Context-->
			<xsl:call-template name="ECRM_X_P7_Y">
				<xsl:with-param name="X_URI" select="$EHE1001_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0007_URI"/>
			</xsl:call-template>
			
			<!--ContextEvent has_timespan ContextEventTimespan-->
			<xsl:call-template name="ECRM_X_P4_Y">
				<xsl:with-param name="X_URI" select="$EHE1001_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0025_URI"/>
			</xsl:call-template>
			
			<!--ContextEventTimespan is_identified_by ContextEventTimespanAppellation-->
			<xsl:call-template name="ECRM_X_P1_Y">
				<xsl:with-param name="X_URI" select="$EHE0025_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0026_URI"/>
			</xsl:call-template>
			
			<!--ContextEventTimespan at_some_time_within period-->
			<xsl:call-template name="ECRM_X_P82_Y">
				<xsl:with-param name="X_URI" select="$EHE0025_URI"/>
				<xsl:with-param name="Y_VAL">
					<xsl:value-of select="normalize-space($CONTEXT_PERIOD)"/>					
				</xsl:with-param>
			</xsl:call-template>

		</xsl:if>
		
		<!--WITHIN_CONTEXT_ID-->
		<xsl:if test="normalize-space($WITHIN_CONTEXT_ID) != ''">
			<!--Create 2nd Context URI-->
			<xsl:variable name="EHE0007_URI2">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0007</xsl:with-param>
					<xsl:with-param name="ID" select="$WITHIN_CONTEXT_ID"/>
				</xsl:call-template>
			</xsl:variable>
		
			<!--Create 2nd Context Entity-->
			<xsl:call-template name="CRMEH_EHE0007">
				<xsl:with-param name="URI" select="$EHE0007_URI"/>
			</xsl:call-template>
			
			<!--Context falls_within Context-->
			<xsl:call-template name="ECRM_X_P89_Y">
				<xsl:with-param name="X_URI" select="$EHE0007_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0007_URI2"/>
			</xsl:call-template>
			
		</xsl:if><!--end Context falls_within Context-->	

			
		<!--WITHIN_GROUP_ID-->		
		<xsl:if test="normalize-space($WITHIN_GROUP_ID) != ''">
			<!--Create Group URI-->
			<xsl:variable name="EHE0005_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0005</xsl:with-param>
					<xsl:with-param name="ID" select="$WITHIN_GROUP_ID"/>
				</xsl:call-template>				
			</xsl:variable>			
		
			<!--Create Group Entity-->
			<xsl:call-template name="CRMEH_EHE0005">
				<xsl:with-param name="URI" select="$EHE0005_URI"/>
			</xsl:call-template>				
			
			<!--Context falls_within Group-->
			<xsl:call-template name="ECRM_X_P89_Y">
				<xsl:with-param name="X_URI" select="$EHE0007_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0005_URI"/>
			</xsl:call-template>				

		</xsl:if><!--end Context falls_within Group-->				
		
		<!--STRAT_LOWER_ID-->		
		<xsl:if test="normalize-space($STRAT_LOWER_ID) != ''">
			<xsl:call-template name="CRMEH_CONTEXT_STRATIGRAPHY">
				<xsl:with-param name="CONTEXT_ID1" select="$CONTEXT_ID"/>
				<xsl:with-param name="CONTEXT_ID2" select="$STRAT_LOWER_ID"/>
				<xsl:with-param name="RELATION" select="'LOWER'"/>
			</xsl:call-template>
		</xsl:if><!--end Context stratigraphically below Context-->
		
		<!--STRAT_EQUAL_ID-->		
		<xsl:if test="normalize-space($STRAT_EQUAL_ID) != ''">
			<xsl:call-template name="CRMEH_CONTEXT_STRATIGRAPHY">
				<xsl:with-param name="CONTEXT_ID1" select="$CONTEXT_ID"/>
				<xsl:with-param name="CONTEXT_ID2" select="$STRAT_EQUAL_ID"/>
				<xsl:with-param name="RELATION" select="'EQUAL'"/>
			</xsl:call-template>

		</xsl:if><!--end Context stratigraphically equals Context-->	
		
		<!--WITHIN_INVESTIGATION_ID-->
		<xsl:if test="normalize-space($WITHIN_INVESTIGATION_ID) != ''">
		
			<!--Create AreaOfInterest URI-->
			<xsl:variable name="EHE0003_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0003</xsl:with-param>
					<xsl:with-param name="ID" select="$WITHIN_INVESTIGATION_ID"/>
				</xsl:call-template>				
			</xsl:variable>			
		
			<!--Create AreaOfInterest Entity-->
			<xsl:call-template name="CRMEH_EHE0003">
				<xsl:with-param name="URI" select="$EHE0003_URI"/>
				<xsl:with-param name="LBL" select="normalize-space($WITHIN_INVESTIGATION_ID)"/>
			</xsl:call-template>		
			
			<!--Context falls_within AreaOfInterest-->
			<xsl:call-template name="ECRM_X_P89_Y">
				<xsl:with-param name="X_URI" select="$EHE0007_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0003_URI"/>
			</xsl:call-template>
			
		</xsl:if> <!--end Context falls_within AOI-->

			
	</xsl:template>	<!--end CRMEH_CONTEXT-->
	
	<!--this template called by CRMEH_CONTEXT-->
	<xsl:template name="CRMEH_CONTEXT_STRATIGRAPHY">
		<xsl:param name="CONTEXT_ID1"/>
		<xsl:param name="CONTEXT_ID2"/>
		<xsl:param name="RELATION"/><!--values: 'UPPER', 'LOWER', 'EQUAL'-->

		<!--Create URIs for Context entities-->
		<xsl:variable name="EHE0007_URI1">
			<xsl:call-template name="CRMEH_URI">
				<xsl:with-param name="TYPE">EHE0007</xsl:with-param>
				<xsl:with-param name="ID" select="$CONTEXT_ID1"/>
			</xsl:call-template>
		</xsl:variable>
		
		<xsl:variable name="EHE0007_URI2">
			<xsl:call-template name="CRMEH_URI">
				<xsl:with-param name="TYPE">EHE0007</xsl:with-param>
				<xsl:with-param name="ID" select="$CONTEXT_ID2"/>
			</xsl:call-template>
		</xsl:variable>
			
		<!--Create URIs for ContextEvent entities-->
		<xsl:variable name="EHE1001_URI1">
			<xsl:call-template name="CRMEH_URI">
				<xsl:with-param name="TYPE">EHE1001</xsl:with-param>
				<xsl:with-param name="ID" select="$CONTEXT_ID1"/>
			</xsl:call-template>
		</xsl:variable>
			
		<xsl:variable name="EHE1001_URI2">
			<xsl:call-template name="CRMEH_URI">
				<xsl:with-param name="TYPE">EHE1001</xsl:with-param>
				<xsl:with-param name="ID" select="$CONTEXT_ID2"/>
			</xsl:call-template>
		</xsl:variable>
			
		<!--Create the Context Entities-->
		<!--24/01/11 - commented out - assume the Context entities are already created-->
		<!--		
		<xsl:call-template name="CRMEH_EHE0007">
			<xsl:with-param name="URI" select="$EHE0007_URI1"/>
		</xsl:call-template>
		
		<xsl:call-template name="CRMEH_EHE0007">
			<xsl:with-param name="URI" select="$EHE0007_URI2"/>
		</xsl:call-template>
		-->
			
		<!--Create the 2 ContextEvent Entities-->
		<xsl:call-template name="CRMEH_EHE1001">
			<xsl:with-param name="URI" select="$EHE1001_URI1"/>
		</xsl:call-template>
			
		<xsl:call-template name="CRMEH_EHE1001">
			<xsl:with-param name="URI" select="$EHE1001_URI2"/>
		</xsl:call-template>		
					
		<!-- EHE1001.ContextEvent took_place_at EHE0007.Context-->
		<xsl:call-template name="ECRM_X_P7_Y">
			<xsl:with-param name="X_URI" select="$EHE1001_URI1"/>
			<xsl:with-param name="Y_URI" select="$EHE0007_URI1"/>
		</xsl:call-template>		
			
		<xsl:call-template name="ECRM_X_P7_Y">
			<xsl:with-param name="X_URI" select="$EHE1001_URI2"/>
			<xsl:with-param name="Y_URI" select="$EHE0007_URI2"/>
		</xsl:call-template>
		
		<xsl:choose>
			<xsl:when test="$RELATION = 'UPPER'">
				<!--EHE1001.ContextEvent occurs_before EHE1001.ContextEvent-->
				<xsl:call-template name="ECRM_X_P120_Y">
					<xsl:with-param name="X_URI" select="$EHE1001_URI1"/>
					<xsl:with-param name="Y_URI" select="$EHE1001_URI2"/>
				</xsl:call-template>
			</xsl:when>
			<xsl:when test="$RELATION = 'LOWER'">
				<!--EHE1001.ContextEvent occurs_before EHE1001.ContextEvent-->
				<xsl:call-template name="ECRM_X_P120_Y">
					<xsl:with-param name="X_URI" select="$EHE1001_URI2"/>
					<xsl:with-param name="Y_URI" select="$EHE1001_URI1"/>
				</xsl:call-template>
			</xsl:when>
			<xsl:when test="$RELATION = 'EQUAL'">
				<!--EHE1001.ContextEvent is_equal_in_time_to EHE1001.ContextEvent-->
				<xsl:call-template name="ECRM_X_P114_Y">
					<xsl:with-param name="X_URI" select="$EHE1001_URI1"/>
					<xsl:with-param name="Y_URI" select="$EHE1001_URI2"/>
				</xsl:call-template>
			</xsl:when>
		</xsl:choose>

	</xsl:template><!--end CRMEH_CONTEXT_STRATIGRAPHY-->

	<!--CRMEH_FIND - new 15/11/10-->
	<xsl:template name="CRMEH_FIND">
		<xsl:param name="FIND_ID"/><!--mandatory: group identifier-->
		<xsl:param name="FIND_NOTE"/><!--optional-->
		<xsl:param name="FIND_TYPE"/><!--optional-->	
		<xsl:param name="FIND_TYPE_URI"/><!--optional-->
		<xsl:param name="FIND_MATERIAL"/><!--optional-->	
		<xsl:param name="FIND_MATERIAL_URI"/><!--optional-->
		<xsl:param name="PRODUCTION_PERIOD"/><!--optional-->	
		<!--<xsl:param name="DEPOSITION_PERIOD"/>optional-->	
		<xsl:param name="WITHIN_CONTEXT_ID"/><!--optional (container group)-->
		<xsl:param name="WITHIN_INVESTIGATION_ID"/><!--optional: investigation identifier-->
		<xsl:param name="LANGUAGE"/>
		
		<!--Create the ContextFind URI-->
		<xsl:variable name="EHE0009_URI">
			<xsl:call-template name="CRMEH_URI">
				<xsl:with-param name="TYPE">EHE0009</xsl:with-param>
				<xsl:with-param name="ID" select="$FIND_ID"/>
			</xsl:call-template>				
		</xsl:variable>
		
		<!--Create the ContextFindUID URI-->
		<xsl:variable name="EHE0043_URI">
			<xsl:call-template name="CRMEH_URI">
				<xsl:with-param name="TYPE">EHE0043</xsl:with-param>
				<xsl:with-param name="ID" select="$FIND_ID"/>
			</xsl:call-template>				
		</xsl:variable>

		<!--Create the ContextFind Entity-->
		<xsl:call-template name="CRMEH_EHE0009">
			<xsl:with-param name="URI" select="$EHE0009_URI"/>
			<xsl:with-param name="LBL" select="$FIND_ID"/>
		</xsl:call-template>	
		
		<!--Create the ContextFindUID Entity-->
		<xsl:call-template name="CRMEH_EHE0043">
			<xsl:with-param name="URI" select="$EHE0043_URI"/>
			<xsl:with-param name="VAL" select="$FIND_ID"/>
		</xsl:call-template>			
		
		<!--Create ContextFindIdentifierAssignmentEvent URI-->
		<xsl:variable name="EHE2013_URI">
			<xsl:call-template name="CRMEH_URI">
				<xsl:with-param name="TYPE">EHE2013</xsl:with-param>
				<xsl:with-param name="ID" select="$FIND_ID"/>
			</xsl:call-template>
		</xsl:variable>
		
		<!--Create the ContextFindIdentifierAssignmentEvent Entity-->
		<xsl:call-template name="CRMEH_EHE2013">
			<xsl:with-param name="URI" select="$EHE2013_URI"/>
		</xsl:call-template>
				
		<!-- ContextFindIdentifierAssignmentEvent assigned_attribute_to ContextFind-->
		<xsl:call-template name="ECRM_X_P140_Y">
			<xsl:with-param name="X_URI" select="$EHE2013_URI"/>
			<xsl:with-param name="Y_URI" select="$EHE0009_URI"/>
		</xsl:call-template>		
		
		<!--ContextFindIdentifierAssignmentEvent assigned ContextFindUID-->
		<xsl:call-template name="ECRM_X_P37_Y">
			<xsl:with-param name="X_URI" select="$EHE2013_URI"/>
			<xsl:with-param name="Y_URI" select="$EHE0043_URI"/>
		</xsl:call-template>	
		
		<!--ContextFind is_identified_by ContextFindUID (shortcut)-->
		<xsl:call-template name="ECRM_X_P1_Y">
			<xsl:with-param name="X_URI" select="$EHE0009_URI"/>
			<xsl:with-param name="Y_URI" select="$EHE0043_URI"/>
		</xsl:call-template>
		
		<!--FIND_NOTE-->	
		<xsl:if test="normalize-space($FIND_NOTE) != ''">
			<xsl:call-template name="ECRM_X_P3_Y">
				<xsl:with-param name="X_URI" select="$EHE0009_URI"/>
				<xsl:with-param name="Y_VAL">
					<xsl:value-of select="$FIND_NOTE"/>
				</xsl:with-param> 
				<xsl:with-param name="LANGUAGE" select="$LANGUAGE"/>
			</xsl:call-template>
		</xsl:if>		
		
		<!--FIND_TYPE_URI-->
		<xsl:if test="normalize-space($FIND_TYPE_URI) != ''">
			<!--Find has_type Type-->
			<xsl:call-template name="ECRM_X_P2_Y">
				<xsl:with-param name="X_URI" select="$EHE0009_URI"/>
				<xsl:with-param name="Y_URI" select="normalize-space($FIND_TYPE_URI)"/>
			</xsl:call-template>
		</xsl:if>	
		
		<!--FIND_TYPE-->
		<xsl:if test="normalize-space($FIND_TYPE) != ''">	
			<!--Create the E55_EHE0009 URI -->
			<xsl:variable name="E55_EHE0009_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">E55_EHE0009</xsl:with-param>
					<xsl:with-param name="ID" select="normalize-space($FIND_TYPE)"/>
				</xsl:call-template>
			</xsl:variable>
				
			<!--Create the E55_Type Entity-->
			<xsl:call-template name="ECRM_E55">
				<xsl:with-param name="URI" select="$E55_EHE0009_URI"/>
				<xsl:with-param name="LBL" select="normalize-space($FIND_TYPE)"/>
			</xsl:call-template>
	
			<!--Find has_type Type-->
			<xsl:call-template name="ECRM_X_P2_Y">
				<xsl:with-param name="X_URI" select="$EHE0009_URI"/>
				<xsl:with-param name="Y_URI" select="$E55_EHE0009_URI"/>
			</xsl:call-template>		
		</xsl:if>		
		
		<!--FIND_MATERIAL_URI-->
		<xsl:if test="normalize-space($FIND_MATERIAL_URI) != ''">
			<!--Find consists_of Material-->
			<xsl:call-template name="ECRM_X_P45_Y">
				<xsl:with-param name="X_URI" select="$EHE0009_URI"/>
				<xsl:with-param name="Y_URI" select="normalize-space($FIND_MATERIAL_URI)"/>
			</xsl:call-template>
		</xsl:if>	
		
		<!--FIND_MATERIAL-->
		<xsl:if test="normalize-space($FIND_MATERIAL) != ''">	
			<!--Create the EHE0030 URI -->
			<xsl:variable name="EHE0030_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0030</xsl:with-param>
					<xsl:with-param name="ID" select="normalize-space($FIND_MATERIAL)"/>
				</xsl:call-template>
			</xsl:variable>
				
			<!--Create the EHE0030 Entity-->
			<xsl:call-template name="CRMEH_EHE0030">
				<xsl:with-param name="URI" select="$EHE0030_URI"/>
				<xsl:with-param name="LBL" select="normalize-space($FIND_MATERIAL)"/>
			</xsl:call-template>
	
			<!--Find consists_of Material-->
			<xsl:call-template name="ECRM_X_P45_Y">
				<xsl:with-param name="X_URI" select="$EHE0009_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0030_URI"/>
			</xsl:call-template>		
		</xsl:if>
		
		<!--ContextFindProductionEvent dates-->
		<xsl:if test="normalize-space($PRODUCTION_PERIOD) != ''">
			<!--Create the ContextFindProductionEvent URI-->
			<xsl:variable name="EHE1002_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE1002</xsl:with-param>
					<xsl:with-param name="ID" select="normalize-space($FIND_ID)"/>
				</xsl:call-template>
			</xsl:variable>
			
			<!--Create the ContextFindProductionEventTimespan URI-->
			<xsl:variable name="EHE0038_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0038</xsl:with-param>
					<xsl:with-param name="ID" select="normalize-space($FIND_ID)"/>
				</xsl:call-template>
			</xsl:variable>
			
			<!--Create the ContextFindProductionEventTimespanAppellation URI-->
			<xsl:variable name="EHE0039_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0039</xsl:with-param>
					<xsl:with-param name="ID" select="normalize-space($FIND_ID)"/>
				</xsl:call-template>
			</xsl:variable>
			
			<!--Create the ContextFindProductionEvent Entity-->
			<xsl:call-template name="CRMEH_EHE1002">
				<xsl:with-param name="URI" select="$EHE1002_URI"/>				
			</xsl:call-template>	
			
			<!--Create the ContextFindProductionEventTimespan Entity-->
			<xsl:call-template name="CRMEH_EHE0038">
				<xsl:with-param name="URI" select="$EHE0038_URI"/>				
			</xsl:call-template>	
			
			<!--Create the ContextFindProductionEventTimespanAppellation Entity-->
			<xsl:call-template name="CRMEH_EHE0039">
				<xsl:with-param name="URI" select="$EHE0039_URI"/>	
				<xsl:with-param name="VAL" select="$PRODUCTION_PERIOD"/>					
			</xsl:call-template>		
			
			<!--ContextFindProductionEvent produced ContextFind-->
			<xsl:call-template name="ECRM_X_P108_Y">
				<xsl:with-param name="X_URI" select="$EHE1002_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0009_URI"/>
			</xsl:call-template>
			
			<!--ContextFindProductionEvent has_timespan ContextFindProductionEventTimespan-->
			<xsl:call-template name="ECRM_X_P4_Y">
				<xsl:with-param name="X_URI" select="$EHE1002_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0038_URI"/>
			</xsl:call-template>
			
			<!--ContextFindProductionEvent is_identified_by ContextFindProductionEventTimespanAppellation-->
			<xsl:call-template name="ECRM_X_P1_Y">
				<xsl:with-param name="X_URI" select="$EHE0038_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0039_URI"/>
			</xsl:call-template>
			
			<!--ContextFindProductionEventTimespan at_some_time_within period-->
			<xsl:call-template name="ECRM_X_P82_Y">
				<xsl:with-param name="X_URI" select="$EHE0038_URI"/>
				<xsl:with-param name="Y_VAL">
					<xsl:value-of select="normalize-space($PRODUCTION_PERIOD)"/>					
				</xsl:with-param>
			</xsl:call-template>

		</xsl:if>
			
		<!--ContextFind within Context-->		
		<xsl:if test="normalize-space($WITHIN_CONTEXT_ID) != ''">
			
			<!--Create URIs for each of the entities required in the property chain-->
			<!--Create Context URI-->
			<xsl:variable name="EHE0007_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0007</xsl:with-param>
					<xsl:with-param name="ID" select="$WITHIN_CONTEXT_ID"/>
				</xsl:call-template>
			</xsl:variable>			
			
			<!--Create ContextFindDepositionEvent URI-->
			<xsl:variable name="EHE1004_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE1004</xsl:with-param>
					<xsl:with-param name="ID" select="$FIND_ID"/>
				</xsl:call-template>
			</xsl:variable>
			
			<!--Create the Context Entity-->
			<xsl:call-template name="CRMEH_EHE0007">
				<xsl:with-param name="URI" select="$EHE0007_URI"/>
			</xsl:call-template>
			
			<!--Create the ContextFindDepositionEvent Entity-->
			<xsl:call-template name="CRMEH_EHE1004">
				<xsl:with-param name="URI" select="$EHE1004_URI"/>
			</xsl:call-template>
					
			<!--ContextFindDepositionEvent moved_to Context-->
			<xsl:call-template name="ECRM_X_P26_Y">
				<xsl:with-param name="X_URI" select="$EHE1004_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0007_URI"/>
			</xsl:call-template>
			
			<!--ContextFindDepositionEvent moved ContextFind-->
			<xsl:call-template name="ECRM_X_P25_Y">
				<xsl:with-param name="X_URI" select="$EHE1004_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0009_URI"/>
			</xsl:call-template>
			
			<!--ContextFind has_former_or_current_location Context (shortcut)-->
			<xsl:call-template name="ECRM_X_P53_Y">
				<xsl:with-param name="X_URI" select="$EHE0009_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0007_URI"/>
			</xsl:call-template>
			
		</xsl:if><!--end ContextFind falls_within Context-->
		
		<!--ContextFind has_former_or_current_location AOI-->
		<xsl:if test="normalize-space($WITHIN_INVESTIGATION_ID) != ''">
		
			<!--Create AreaOfInterest URI-->
			<xsl:variable name="EHE0003_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0003</xsl:with-param>
					<xsl:with-param name="ID" select="$WITHIN_INVESTIGATION_ID"/>
				</xsl:call-template>
			</xsl:variable>
		
			<!--Create AreaOfInterest Entity-->
			<xsl:call-template name="CRMEH_EHE0003">
				<xsl:with-param name="URI" select="$EHE0003_URI"/>
				<xsl:with-param name="LBL" select="normalize-space($WITHIN_INVESTIGATION_ID)"/>
			</xsl:call-template>
			
			<!--ContextFind has_former_or_current_location AreaOfInterest-->
			<xsl:call-template name="ECRM_X_P53_Y">
				<xsl:with-param name="X_URI" select="$EHE0009_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0003_URI"/>
			</xsl:call-template>

		</xsl:if> <!--end ContextFind has_former_or_current_location AOI-->
	
	</xsl:template>	<!--end CRMEH_FIND-->

	
	<!--CRMEH_SAMPLE - new 15/11/10-->
	<xsl:template name="CRMEH_SAMPLE">
		<xsl:param name="SAMPLE_ID"/><!--mandatory: sample identifier-->
		<xsl:param name="SAMPLE_NOTE"/><!--optional-->
		<xsl:param name="SAMPLE_TYPE"/><!--optional-->
		<xsl:param name="SAMPLE_TYPE_URI"/><!--optional-->
		<xsl:param name="WITHIN_CONTEXT_ID"/><!--optional (container context)-->
		<xsl:param name="WITHIN_INVESTIGATION_ID"/><!--optional: investigation identifier-->	
		<xsl:param name="LANGUAGE"/>

		<!--new 05/01/11 - sample measurement-->
		<xsl:param name="MEASUREMENT_TYPE"/><!--optional-->	
		<xsl:param name="MEASUREMENT_TYPE_URI"/><!--optional-->	
		<xsl:param name="MEASUREMENT_UNIT"/><!--optional-->	
		<xsl:param name="MEASUREMENT_UNIT_URI"/><!--optional-->	
		<xsl:param name="MEASUREMENT_VALUE"/><!--optional-->
		
		<!--Create the Sample URI-->
		<xsl:variable name="EHE0018_URI">
			<xsl:call-template name="CRMEH_URI">
				<xsl:with-param name="TYPE">EHE0018</xsl:with-param>
				<xsl:with-param name="ID" select="$SAMPLE_ID"/>
			</xsl:call-template>
		</xsl:variable>
		
		<!--Create the Sample identifier URI-->
		<xsl:variable name="E42_EHE0018_URI">
			<xsl:call-template name="CRMEH_URI">
				<xsl:with-param name="TYPE">E42_EHE0018</xsl:with-param>
				<xsl:with-param name="ID" select="$SAMPLE_ID"/>
			</xsl:call-template>
		</xsl:variable>

		<!--Create the Sample Entity-->
		<xsl:call-template name="CRMEH_EHE0018">
			<xsl:with-param name="URI" select="$EHE0018_URI"/>
			<xsl:with-param name="LBL" select="$SAMPLE_ID"/>
		</xsl:call-template>		
		
		<!--Create the Sample identifier Entity-->
		<xsl:call-template name="ECRM_E42">
			<xsl:with-param name="URI" select="$E42_EHE0018_URI"/>
			<xsl:with-param name="VAL" select="$SAMPLE_ID"/>
		</xsl:call-template>	
		
		<!--Sample is_identified_by identifier-->
		<xsl:call-template name="ECRM_X_P1_Y">
			<xsl:with-param name="X_URI" select="$EHE0018_URI"/>
			<xsl:with-param name="Y_URI" select="$E42_EHE0018_URI"/>
		</xsl:call-template>
		
		<!--SAMPLE_NOTE-->	
		<xsl:if test="normalize-space($SAMPLE_NOTE) != ''">
			<xsl:call-template name="ECRM_X_P3_Y">
				<xsl:with-param name="X_URI" select="$EHE0018_URI"/>
				<xsl:with-param name="Y_VAL">
					<xsl:value-of select="$SAMPLE_NOTE"/>	
				</xsl:with-param> 
				<xsl:with-param name="LANGUAGE" select="$LANGUAGE"/>
			</xsl:call-template>
		</xsl:if>
		
		<!--SAMPLE_TYPE_URI-->
		<xsl:if test="normalize-space($SAMPLE_TYPE_URI) != ''">
			<!--Find has_type Type-->
			<xsl:call-template name="ECRM_X_P2_Y">
				<xsl:with-param name="X_URI" select="$EHE0018_URI"/>
				<xsl:with-param name="Y_URI" select="normalize-space($SAMPLE_TYPE_URI)"/>
			</xsl:call-template>
		</xsl:if>	
		
		<!--SAMPLE_TYPE-->
		<xsl:if test="normalize-space($SAMPLE_TYPE) != ''">	
			<!--Create the EHE0053 URI -->
			<xsl:variable name="EHE0053_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0053</xsl:with-param>
					<xsl:with-param name="ID" select="normalize-space($SAMPLE_TYPE)"/>
				</xsl:call-template>
			</xsl:variable>
				
			<!--Create the EHE0053 Entity-->
			<xsl:call-template name="CRMEH_EHE0053">
				<xsl:with-param name="URI" select="$EHE0053_URI"/>
				<xsl:with-param name="LBL" select="normalize-space($SAMPLE_TYPE)"/>
			</xsl:call-template>
	
			<!--Sample has_type SampleType-->
			<xsl:call-template name="ECRM_X_P2_Y">
				<xsl:with-param name="X_URI" select="$EHE0018_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0053_URI"/>
			</xsl:call-template>		
		</xsl:if>
			
		<!--WITHIN_CONTEXT_ID-->		
		<xsl:if test="normalize-space($WITHIN_CONTEXT_ID) != ''">
			<!--Create URIs for each of the entities required in the property chain-->
			<!--Create Context URI-->
			<xsl:variable name="EHE0007_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0007</xsl:with-param>
					<xsl:with-param name="ID" select="$WITHIN_CONTEXT_ID"/>
				</xsl:call-template>				
			</xsl:variable>
			
			<!--Create ContextStuff URI-->
			<xsl:variable name="EHE0008_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0008</xsl:with-param>
					<xsl:with-param name="ID" select="$WITHIN_CONTEXT_ID"/>
				</xsl:call-template>				
			</xsl:variable>			
			
			<!--Create ContextSamplingEvent URI-->
			<xsl:variable name="EHE2006_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE2006</xsl:with-param>
					<xsl:with-param name="ID" select="$SAMPLE_ID"/>
				</xsl:call-template>				
			</xsl:variable>	
		
			<!--Create Context Entity-->
			<xsl:call-template name="CRMEH_EHE0007">
				<xsl:with-param name="URI" select="$EHE0007_URI"/>
			</xsl:call-template>		
			
			<!--Create ContextStuff Entity-->
			<xsl:call-template name="CRMEH_EHE0008">
				<xsl:with-param name="URI" select="$EHE0008_URI"/>
			</xsl:call-template>
			
			<!--Create ContextSamplingEvent Entity-->
			<xsl:call-template name="CRMEH_EHE2006">
				<xsl:with-param name="URI" select="$EHE2006_URI"/>
			</xsl:call-template>
					
			<!--ContextStuff occupied Context-->
			<xsl:call-template name="CRMEH_X_EHP3_Y">
				<xsl:with-param name="X_URI" select="$EHE0008_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0007_URI"/>
			</xsl:call-template>
			
			<!--ContextSamplingEvent diminished ContextStuff-->
			<xsl:call-template name="ECRM_X_P112_Y">
				<xsl:with-param name="X_URI" select="$EHE2006_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0008_URI"/>
			</xsl:call-template>
			
			<!--ContextSamplingEvent removed Sample-->
			<xsl:call-template name="ECRM_X_P113_Y">
				<xsl:with-param name="X_URI" select="$EHE2006_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0018_URI"/>
			</xsl:call-template>
			
			<!--ContextSample has_former_or_current_location Context (shortcut)-->
			<xsl:call-template name="ECRM_X_P53_Y">
				<xsl:with-param name="X_URI" select="$EHE0018_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0007_URI"/>
			</xsl:call-template>	

		</xsl:if><!--end Sample within Context-->			
		
		<!--MEASUREMENT_VALUE-->		
		<xsl:if test="normalize-space($MEASUREMENT_VALUE) != ''">
			
			<!--Create ContextSampleProcessingEvent URI-->
			<xsl:variable name="EHE2015_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE2015</xsl:with-param>
					<xsl:with-param name="ID" select="$SAMPLE_ID"/>
				</xsl:call-template>				
			</xsl:variable>
			
			<!--Create ContextSampleMeasurement URI-->
			<xsl:variable name="EHE0049_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0049</xsl:with-param>					
					<xsl:with-param name="ID" select="concat($SAMPLE_ID, '_', normalize-space($MEASUREMENT_TYPE))"/>
				</xsl:call-template>
			</xsl:variable>
			
			<!--Create ContextSampleProcessingEvent Entity-->
			<xsl:call-template name="CRMEH_EHE2015">
				<xsl:with-param name="URI" select="$EHE2015_URI"/>
			</xsl:call-template>
			
			<!--Create ContextSampleMeasurement Entity-->
			<xsl:call-template name="CRMEH_EHE0049">
				<xsl:with-param name="URI" select="$EHE0049_URI"/>
			</xsl:call-template>
			
			<!--ContextSampleProcessingEvent measures ContextSample-->
			<xsl:call-template name="ECRM_X_P39_Y">
				<xsl:with-param name="X_URI" select="$EHE2015_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0018_URI"/>
			</xsl:call-template>
			
			<!--ContextSampleProcessingEvent observed_dimension ContextSampleMeasurement-->
			<xsl:call-template name="ECRM_X_P40_Y">
				<xsl:with-param name="X_URI" select="$EHE2015_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0049_URI"	/>
			</xsl:call-template>	
			
			<!--ContextSampleMeasurement has_value ContextSampleMeasurementValue-->
			<xsl:call-template name="ECRM_X_P90_Y">
				<xsl:with-param name="X_URI" select="$EHE0049_URI"/>
				<xsl:with-param name="Y_VAL" select="normalize-space($MEASUREMENT_VALUE)"/>
			</xsl:call-template>
			
			<!--MEASUREMENT_UNIT_URI-->
			<xsl:if test="normalize-space($MEASUREMENT_UNIT_URI) != ''">
				<!--ContextSampleMeasurement has_unit ContextSampleMeasurementUnit-->
				<xsl:call-template name="ECRM_X_P91_Y">
					<xsl:with-param name="X_URI" select="$EHE0049_URI"/>
					<xsl:with-param name="Y_URI" select="normalize-space($MEASUREMENT_UNIT_URI)"/>
				</xsl:call-template>
			</xsl:if>	

			<!--ContextSampleMeasurement has_unit ContextSampleMeasurementUnit-->
			<xsl:if test="normalize-space($MEASUREMENT_UNIT) != ''">				
				<!--Create ContextSampleMeasurementUnit URI-->
				<xsl:variable name="EHE0051_URI">
					<xsl:call-template name="CRMEH_URI">
						<xsl:with-param name="TYPE">EHE0051</xsl:with-param>
						<xsl:with-param name="ID" select="normalize-space($MEASUREMENT_UNIT)"/>
					</xsl:call-template>				
				</xsl:variable>
				
				<!--Create ContextSampleMeasurementUnit Entity-->
				<xsl:call-template name="CRMEH_EHE0051">
					<xsl:with-param name="URI" select="$EHE0051_URI"/>
				</xsl:call-template>
				
				<!--ContextSampleMeasurement has_unit ContextSampleMeasurementUnit-->
				<xsl:call-template name="ECRM_X_P91_Y">
					<xsl:with-param name="X_URI" select="$EHE0049_URI"/>
					<xsl:with-param name="Y_URI" select="$EHE0051_URI"/>
				</xsl:call-template>				
			</xsl:if><!--end ContextSampleMeasurement has_unit ContextSampleMeasurementUnit-->			
			
			<!--MEASUREMENT_TYPE_URI-->
			<xsl:if test="normalize-space($MEASUREMENT_TYPE_URI) != ''">
				<!--Group has_type Type-->
				<xsl:call-template name="ECRM_X_P2_Y">
					<xsl:with-param name="X_URI" select="$EHE0049_URI"/>
					<xsl:with-param name="Y_URI" select="normalize-space($MEASUREMENT_TYPE_URI)"/>
				</xsl:call-template>
			</xsl:if>	
			
			<!--MEASUREMENT_TYPE-->
			<xsl:if test="normalize-space($MEASUREMENT_TYPE) != ''">	
				<!--Create ContextSampleMeasurementType URI-->
				<xsl:variable name="EHE0050_URI">
					<xsl:call-template name="CRMEH_URI">
						<xsl:with-param name="TYPE">EHE0050</xsl:with-param>
						<xsl:with-param name="ID" select="normalize-space($MEASUREMENT_TYPE)"/>
					</xsl:call-template>				
				</xsl:variable>
					
				<!--Create ContextSampleMeasurementType Entity-->
				<xsl:call-template name="CRMEH_EHE0050">
					<xsl:with-param name="URI" select="$EHE0050_URI"/>
				</xsl:call-template>

				<xsl:call-template name="ECRM_X_P2_Y">
					<xsl:with-param name="X_URI" select="$EHE0049_URI"/>
					<xsl:with-param name="Y_URI" select="$EHE0050_URI"/>
				</xsl:call-template>
			</xsl:if>
		
		</xsl:if><!--end ContextSampleMeasurement-->	
		
		<!--ContextSample has_former_or_current_location AOI-->
		<xsl:if test="normalize-space($WITHIN_INVESTIGATION_ID) != ''">
		
			<!--Create AreaOfInterest URI-->
			<xsl:variable name="EHE0003_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0003</xsl:with-param>
					<xsl:with-param name="ID" select="normalize-space($WITHIN_INVESTIGATION_ID)"/>
				</xsl:call-template>
			</xsl:variable>
			
			<!--Create AreaOfInterest Entity-->
			<xsl:call-template name="CRMEH_EHE0003">
				<xsl:with-param name="URI" select="$EHE0003_URI"/>
				<xsl:with-param name="LBL" select="normalize-space($WITHIN_INVESTIGATION_ID)"/>
			</xsl:call-template>
			
			<!--ContextSample has_former_or_current_location AOI-->
			<xsl:call-template name="ECRM_X_P53_Y">
				<xsl:with-param name="X_URI" select="$EHE0018_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0003_URI"/>
			</xsl:call-template>

		</xsl:if> <!--end ContextSample has_former_or_current_location AOI-->

	</xsl:template>	<!--end CRMEH_SAMPLE-->
	
	<!--CRMEH_INVESTIGATION - not used yet.. composite template for sites-->
	<xsl:template name="CRMEH_INVESTIGATION">
		<xsl:param name="INVESTIGATION_ID"/><!--mandatory: site identifier-->
		<xsl:param name="INVESTIGATION_TYPE"/><!--optional-->
		<xsl:param name="INVESTIGATION_TYPE_URI"/><!--optional-->
		<xsl:param name="INVESTIGATION_TIMESPAN"/><!--optional-->
		<xsl:param name="INVESTIGATION_DESCRIPTION"/><!--optional-->
		<xsl:param name="INVESTIGATION_LOCATION"/><!--optional-->
		<xsl:param name="LANGUAGE"/><!--optional-->
		
		<!--Create the Project URI-->
		<xsl:variable name="EHE0001_URI">
			<xsl:call-template name="CRMEH_URI">
				<xsl:with-param name="TYPE">EHE0001</xsl:with-param>
				<xsl:with-param name="ID" select="$INVESTIGATION_ID"/>
			</xsl:call-template>
		</xsl:variable>
		
		<!--Create the AOI URI-->
		<xsl:variable name="EHE0003_URI">
			<xsl:call-template name="CRMEH_URI">
				<xsl:with-param name="TYPE">EHE0003</xsl:with-param>
				<xsl:with-param name="ID" select="$INVESTIGATION_ID"/>
			</xsl:call-template>
		</xsl:variable>		
		
		<!--Create the Project Entity-->
		<xsl:call-template name="CRMEH_EHE0001">
			<xsl:with-param name="URI" select="$EHE0001_URI"/>
			<xsl:with-param name="LBL" select="$INVESTIGATION_ID"/>
		</xsl:call-template>
		
		<!--Create the AOI Entity-->
		<xsl:call-template name="CRMEH_EHE0003">
			<xsl:with-param name="URI" select="$EHE0003_URI"/>
			<xsl:with-param name="LBL" select="$INVESTIGATION_ID"/>
		</xsl:call-template>
		
		<!--Project took_place_at AOI-->
		<xsl:call-template name="ECRM_X_P7_Y">
			<xsl:with-param name="X_URI" select="$EHE0001_URI"/>
			<xsl:with-param name="Y_URI" select="$EHE0003_URI"/>
		</xsl:call-template>	
			
		<!--INVESTIGATION_TYPE_URI-->
		<xsl:if test="normalize-space($INVESTIGATION_TYPE_URI) != ''">
			<!--Find has_type Type-->
			<xsl:call-template name="ECRM_X_P2_Y">
				<xsl:with-param name="X_URI" select="$EHE0001_URI"/>
				<xsl:with-param name="Y_URI" select="normalize-space($INVESTIGATION_TYPE_URI)"/>
			</xsl:call-template>
		</xsl:if>	
		
		<!--INVESTIGATION_TYPE-->
		<xsl:if test="normalize-space($INVESTIGATION_TYPE) != ''">	
			<!--Create the E55_EHE0001 URI -->
			<xsl:variable name="E55_EHE0001_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">E55_EHE0001</xsl:with-param>
					<xsl:with-param name="ID" select="normalize-space($INVESTIGATION_TYPE)"/>
				</xsl:call-template>
			</xsl:variable>
				
			<!--Create the E55_Type Entity-->
			<xsl:call-template name="ECRM_E55">
				<xsl:with-param name="URI" select="$E55_EHE0001_URI"/>
				<xsl:with-param name="LBL" select="normalize-space($INVESTIGATION_TYPE)"/>
			</xsl:call-template>
	
			<!--Project has_type Type-->
			<xsl:call-template name="ECRM_X_P2_Y">
				<xsl:with-param name="X_URI" select="$EHE0001_URI"/>
				<xsl:with-param name="Y_URI" select="$E55_EHE0001_URI"/>
			</xsl:call-template>		
		</xsl:if>	
		
		<!--INVESTIGATION_TIMESPAN-->
		<xsl:if test="normalize-space($INVESTIGATION_TIMESPAN) != ''">
			
			<!--Create the EHProjectTimespan URI-->
			<xsl:variable name="EHE0021_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0021</xsl:with-param>
					<xsl:with-param name="ID" select="normalize-space($INVESTIGATION_ID)"/>
				</xsl:call-template>
			</xsl:variable>
			
			<!--Create the E49 TimeAppellation URI-->
			<xsl:variable name="E49_EHE0021_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">E49_EHE0021</xsl:with-param>
					<xsl:with-param name="ID" select="normalize-space($INVESTIGATION_ID)"/>
				</xsl:call-template>
			</xsl:variable>		
			
			<!--Create the EHProjectTimespan Entity-->
			<xsl:call-template name="CRMEH_EHE0021">
				<xsl:with-param name="URI" select="$EHE0021_URI"/>
			</xsl:call-template>	
			
			<!--Create the E49 TimeAppellation Entity-->
			<xsl:call-template name="ECRM_E49">
				<xsl:with-param name="URI" select="$E49_EHE0021_URI"/>	
				<xsl:with-param name="VAL" select="normalize-space($INVESTIGATION_TIMESPAN)"/>
			</xsl:call-template>			
			
			<!--EHProject has_timespan EHProjectTimespan-->
			<xsl:call-template name="ECRM_X_P4_Y">
				<xsl:with-param name="X_URI" select="$EHE0001_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0021_URI"/>
			</xsl:call-template>
			
			<!--EHProjectTimespan is_identified_by TimeAppellation-->
			<xsl:call-template name="ECRM_X_P1_Y">
				<xsl:with-param name="X_URI" select="$EHE0021_URI"/>
				<xsl:with-param name="Y_URI" select="$E49_EHE0021_URI"/>
			</xsl:call-template>
			
			<!--EHProjectTimespan ongoing_throughout period-->
			<xsl:call-template name="ECRM_X_P81_Y">
				<xsl:with-param name="X_URI" select="$EHE0021_URI"/>
				<xsl:with-param name="Y_VAL">
					<xsl:value-of select="normalize-space($INVESTIGATION_TIMESPAN)"/>
				</xsl:with-param>
			</xsl:call-template>

		</xsl:if>						
		
		<!--INVESTIGATION_DESCRIPTION-->
		<xsl:if test="normalize-space($INVESTIGATION_DESCRIPTION) != ''">
			<xsl:call-template name="ECRM_X_P3_Y">
				<xsl:with-param name="X_URI" select="$EHE0001_URI"/>
				<xsl:with-param name="Y_VAL">
					<xsl:value-of select="normalize-space($INVESTIGATION_DESCRIPTION)"/>	
				</xsl:with-param> 				
				<xsl:with-param name="LANGUAGE" select="$LANGUAGE"/>
			</xsl:call-template>
		</xsl:if>
		
		<!--INVESTIGATION_LOCATION-->
		<xsl:if test="normalize-space($INVESTIGATION_LOCATION) != ''">
			<!--Create the AreaOfInvestigationDepiction URI-->
			<xsl:variable name="EHE0019_URI">
				<xsl:call-template name="CRMEH_URI">
					<xsl:with-param name="TYPE">EHE0019</xsl:with-param>
					<xsl:with-param name="ID" select="$INVESTIGATION_ID"/>
				</xsl:call-template>
			</xsl:variable>

			<!--Create the AreaOfInvestigationDepiction Entity-->
			<xsl:call-template name="CRMEH_EHE0019">
				<xsl:with-param name="URI" select="$EHE0019_URI"/>
				<xsl:with-param name="VAL" select="normalize-space($INVESTIGATION_LOCATION)"/>
			</xsl:call-template>

			<!--AOI is_identified_by AreaOfInvestigationDepiction-->
			<xsl:call-template name="ECRM_X_P87_Y">
				<xsl:with-param name="X_URI" select="$EHE0003_URI"/>
				<xsl:with-param name="Y_URI" select="$EHE0019_URI"/>
			</xsl:call-template>
		</xsl:if>		

	</xsl:template><!--end CRMEH_INVESTIGATION-->

</xsl:stylesheet>
