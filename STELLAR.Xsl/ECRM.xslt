<?xml version="1.0" encoding="UTF-8"?>
<!--
STELLAR template library for creating all CRM entities and relationships
(Based on Erlangen Implementation, v.ECRM 101001)
Created by Ceri Binding, University of Glamorgan

Revision History:
=============================================================================== 
Ref		Date		   Who	Description
=============================================================================== 
1.0		2010-11-03	CFB	Initially created template library
-->
<xsl:stylesheet version="2.0" exclude-result-prefixes="xsl ext"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:xsd="http://www.w3.org/2001/XMLSchema#"
	xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#" 
	xmlns:rdfs="http://www.w3.org/2000/01/rdf-schema#" 
	xmlns:ecrm="http://erlangen-crm.org/101001/"
	xmlns:ext="stellar:ext">
	
	<xsl:import href="RDF.xslt"/>
	
	<xsl:output method="xml" version="1.0" encoding="UTF-8" indent="yes"/>
	<xsl:preserve-space elements="*"/>		
	
	<!--template creates Entity instance. URI, LBL and VAL are optional-->
	<xsl:template name="ECRM_E1">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E1_CRM_Entity>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E1_CRM_Entity>
	</xsl:template>
	
	<!--template creates Temporal_Entity instance-->
	<xsl:template name="ECRM_E2">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E2_Temporal_Entity>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E2_Temporal_Entity>		
	</xsl:template>

	<!--template creates Condition_State instance-->
	<xsl:template name="ECRM_E3">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
				
		<ecrm:E3_Condition_State>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E3_Condition_State>	
	</xsl:template>
	
	<!--template creates Period instance-->
	<xsl:template name="ECRM_E4">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
				
		<ecrm:E4_Period>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E4_Period>		
	</xsl:template>
	
	<!--template creates Event instance-->
	<xsl:template name="ECRM_E5">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
				
		<ecrm:E5_Event>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E5_Event>	
	</xsl:template>

	<!--template creates Destruction instance-->
	<xsl:template name="ECRM_E6">		
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
				
		<ecrm:E6_Destruction>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E6_Destruction>					
	</xsl:template>

	<!--template creates Activity instance-->
	<xsl:template name="ECRM_E7">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
				
		<ecrm:E7_Activity>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E7_Activity>			
	</xsl:template>

	<!--template creates Acquisition instance-->
	<xsl:template name="ECRM_E8">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
				
		<ecrm:E8_Acquisition>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E8_Acquisition>					
	</xsl:template>
	
	<!--template creates Move instance-->
	<xsl:template name="ECRM_E9">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
				
		<ecrm:E9_Move>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E9_Move>			
	</xsl:template>
	
	<!--template creates Transfer_of_Custody instance-->
	<xsl:template name="ECRM_E10">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
				
		<ecrm:E10_Transfer_of_Custody>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E10_Transfer_of_Custody>				
	</xsl:template>
	
	<!--template creates Modification instance-->
	<xsl:template name="ECRM_E11">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E11_Modification>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E11_Modification>			
	</xsl:template>

	<!--template creates Production instance-->
	<xsl:template name="ECRM_E12">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E12_Production>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E12_Production>				
	</xsl:template>

	<!--template creates Attribute_Assignment instance-->
	<xsl:template name="ECRM_E13">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E13_Attribute_Assignment>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E13_Attribute_Assignment>					
	</xsl:template>

	<!--template creates Condition_Assessment instance-->
	<xsl:template name="ECRM_E14">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E14_Condition_Assessment>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E14_Condition_Assessment>			
	</xsl:template>

	<!--template creates Identifier_Assigment instance-->
	<xsl:template name="ECRM_E15">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E15_Identifier_Assigment>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E15_Identifier_Assigment>			
	</xsl:template>

	<!--template creates Measurement instance-->
	<xsl:template name="ECRM_E16">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E16_Measurement>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E16_Measurement>			
	</xsl:template>
	
	<!--template creates Type_Assigment instance-->
	<xsl:template name="ECRM_E17">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E17_Type_Assignment>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E17_Type_Assignment>						
	</xsl:template>

	<!--template creates Physical_Thing instance-->
	<xsl:template name="ECRM_E18">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E18_Physical_Thing>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E18_Physical_Thing>			
	</xsl:template>
	
	<!--template creates Physical_Object instance-->
	<xsl:template name="ECRM_E19">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E19_Physical_Object>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E19_Physical_Object>			
	</xsl:template>
	
	<!--template creates Biological_Object instance-->
	<xsl:template name="ECRM_E20">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E20_Biological_Object>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E20_Biological_Object>				
	</xsl:template>
	
	<!--template creates Person instance-->
	<xsl:template name="ECRM_E21">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
				
		<ecrm:E21_Person>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E21_Person>		
	</xsl:template>

	<!--template creates Man-Made_Object instance-->
	<xsl:template name="ECRM_E22">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E22_Man-Made_Object>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E22_Man-Made_Object>		
	</xsl:template>

	<!--template creates Physical_Man-Made_Thing instance-->
	<xsl:template name="ECRM_E24">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E24_Physical_Man-Made_Thing>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E24_Physical_Man-Made_Thing>			
	</xsl:template>

	<!--template creates Man-Made_Feature instance-->
	<xsl:template name="ECRM_E25">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E25_Man-Made_Feature>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E25_Man-Made_Feature>				
	</xsl:template>
	
	<!--template creates Physical_Feature instance-->
	<xsl:template name="ECRM_E26">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E26_Physical_Feature>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E26_Physical_Feature>					
	</xsl:template>
	
	<!--template creates Site instance-->
	<xsl:template name="ECRM_E27">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E27_Site>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E27_Site>				
	</xsl:template>

	<!--template creates Conceptual_Object instance-->
	<xsl:template name="ECRM_E28">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E28_Conceptual_Object>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E28_Conceptual_Object>				
	</xsl:template>
	
	<!--template creates Design_or_Procedure instance-->
	<xsl:template name="ECRM_E29">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E29_Design_or_Procedure>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E29_Design_or_Procedure>				
	</xsl:template>
	
	<!--template creates Right instance-->
	<xsl:template name="ECRM_E30">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E30_Right>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E30_Right>			
	</xsl:template>

	<!--template creates Document instance-->
	<xsl:template name="ECRM_E31">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E31_Document>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E31_Document>			
	</xsl:template>

	<!--template creates Authority_Document instance-->
	<xsl:template name="ECRM_E32">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E32_Authority_Document>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E32_Authority_Document>				
	</xsl:template>

	<!--template creates Linguistic_Object instance-->
	<xsl:template name="ECRM_E33">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E33_Linguistic_Object>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E33_Linguistic_Object>			
	</xsl:template>

	<!--template creates Inscription instance-->
	<xsl:template name="ECRM_E34">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E34_Inscription>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E34_Inscription>			
	</xsl:template>
	
	<!--template creates Title instance-->
	<xsl:template name="ECRM_E35">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E35_Title>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E35_Title>		
	</xsl:template>
	
	<!--template creates Visual_Item instance-->
	<xsl:template name="ECRM_E36">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E36_Visual_Item>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E36_Visual_Item>
	</xsl:template>
	
	<!--template creates Mark instance-->
	<xsl:template name="ECRM_E37">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E37_Mark>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E37_Mark>
	</xsl:template>

	<!--template creates Image instance-->
	<xsl:template name="ECRM_E38">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E38_Image>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E38_Image>		
	</xsl:template>
	
	<!--template creates Actor instance-->
	<xsl:template name="ECRM_E39">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E39_Actor>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E39_Actor>
	</xsl:template>

	<!--template creates Legal_Body instance-->
	<xsl:template name="ECRM_E40">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E40_Legal_Body>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E40_Legal_Body>
	</xsl:template>
	
	<!--template creates Appellation instance-->
	<xsl:template name="ECRM_E41">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E41_Appellation>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E41_Appellation>
	</xsl:template>
	
	<!--template creates Identifier instance-->
	<xsl:template name="ECRM_E42">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E42_Identifier>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E42_Identifier>
	</xsl:template>
	
	<!--template creates Place_Appellation instance-->
	<xsl:template name="ECRM_E44">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E44_Place_Appellation>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E44_Place_Appellation>
	</xsl:template>

	<!--template creates Address instance-->
	<xsl:template name="ECRM_E45">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E45_Address>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E45_Address>
	</xsl:template>
	
	<!--template creates Section_Definition instance-->
	<xsl:template name="ECRM_E46">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E46_Section_Definition>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E46_Section_Definition>
	</xsl:template>
	
	<!--template creates Spatial_Coordinates instance-->
	<xsl:template name="ECRM_E47">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E47_Spatial_Coordinates>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E47_Spatial_Coordinates>
	</xsl:template>
	
	<!--template creates Place_Name instance-->
	<xsl:template name="ECRM_E48">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E48_Place_Name>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E48_Place_Name>
	</xsl:template>

	<!--template creates Time_Appellation instance-->
	<xsl:template name="ECRM_E49">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E49_Time_Appellation>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E49_Time_Appellation>
	</xsl:template>
	
	<!--template creates Date instance-->
	<xsl:template name="ECRM_E50">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E50_Date>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E50_Date>
	</xsl:template>

	<!--template creates Contact_Point instance-->
	<xsl:template name="ECRM_E51">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E51_Contact_Point>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E51_Contact_Point>
	</xsl:template>

	<!--template creates Time-Span instance-->
	<xsl:template name="ECRM_E52">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E52_Time-Span>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E52_Time-Span>
	</xsl:template>
	
	<!--template creates Place instance-->
	<xsl:template name="ECRM_E53">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E53_Place>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E53_Place>
	</xsl:template>

	<!--template creates Dimension instance-->
	<xsl:template name="ECRM_E54">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E54_Dimension>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E54_Dimension>
	</xsl:template>

	<!--template creates Type instance-->
	<xsl:template name="ECRM_E55">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E55_Type>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E55_Type>
	</xsl:template>

	<!--template creates Language instance-->
	<xsl:template name="ECRM_E56">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E56_Language>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E56_Language>
	</xsl:template>

	<!--template creates Material instance-->
	<xsl:template name="ECRM_E57">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E57_Material>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E57_Material>
	</xsl:template>

	<!--template creates Measurement_Unit instance-->
	<xsl:template name="ECRM_E58">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E58_Measurement_Unit>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E58_Measurement_Unit>
	</xsl:template>
	
	<!--template creates Beginning_of_Existence instance-->
	<xsl:template name="ECRM_E63">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E63_Beginning_of_Existence>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E63_Beginning_of_Existence>
	</xsl:template>
	
	<!--template creates End_of_Existence instance-->
	<xsl:template name="ECRM_E64">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E64_End_of_Existence>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E64_End_of_Existence>
	</xsl:template>

	<!--template creates Creation instance-->
	<xsl:template name="ECRM_E65">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E65_Creation>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E65_Creation>
	</xsl:template>

	<!--template creates Formation instance-->
	<xsl:template name="ECRM_E66">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E66_Formation>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E66_Formation>
	</xsl:template>
	
	<!--template creates Birth instance-->
	<xsl:template name="ECRM_E67">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E67_Birth>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E67_Birth>
	</xsl:template>
	
	<!--template creates Dissolution instance-->
	<xsl:template name="ECRM_E68">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E68_Dissolution>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E68_Dissolution>
	</xsl:template>
	
	<!--template creates Death instance-->
	<xsl:template name="ECRM_E69">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E69_Death>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E69_Death>
	</xsl:template>
	
	<!--template creates Thing instance-->
	<xsl:template name="ECRM_E70">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E70_Thing>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E70_Thing>
	</xsl:template>

	<!--template creates Man-Made_Thing instance-->
	<xsl:template name="ECRM_E71">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E71_Man-Made_Thing>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E71_Man-Made_Thing>
	</xsl:template>
	
	<!--template creates Legal_Object instance-->
	<xsl:template name="ECRM_E72">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E72_Legal_Object>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E72_Legal_Object>
	</xsl:template>
	
	<!--template creates Information_Object instance-->
	<xsl:template name="ECRM_E73">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E73_Information_Object>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E73_Information_Object>
	</xsl:template>

	<!--template creates Group instance-->
	<xsl:template name="ECRM_E74">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E74_Group>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E74_Group>
	</xsl:template>

	<!--template creates Conceptual_Object_Appellation instance-->
	<xsl:template name="ECRM_E75">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E75_Conceptual_Object_Appellation>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E75_Conceptual_Object_Appellation>
	</xsl:template>

	<!--template creates Persistent_Item instance-->
	<xsl:template name="ECRM_E77">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E77_Persistent_Item>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E77_Persistent_Item>
	</xsl:template>

	<!--template creates Collection instance-->
	<xsl:template name="ECRM_E78">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E78_Collection>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E78_Collection>
	</xsl:template>

	<!--template creates Part_Addition instance-->
	<xsl:template name="ECRM_E79">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E79_Part_Addition>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E79_Part_Addition>
	</xsl:template>

	<!--template creates Part_Removal instance-->
	<xsl:template name="ECRM_E80">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E80_Part_Removal>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E80_Part_Removal>
	</xsl:template>
	
	<!--template creates Transformation instance-->
	<xsl:template name="ECRM_E81">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E81_Transformation>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E81_Transformation>
	</xsl:template>
	
	<!--template creates Actor_Appellation instance-->
	<xsl:template name="ECRM_E82">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E82_Actor_Appellation>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E82_Actor_Appellation>
	</xsl:template>

	<!--template creates Type_Creation instance-->
	<xsl:template name="ECRM_E83">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E83_Type_Creation>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E83_Type_Creation>
	</xsl:template>
	
	<!--template creates Information_Carrier instance-->
	<xsl:template name="ECRM_E84">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E84_Information_Carrier>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E84_Information_Carrier>
	</xsl:template>
	
	<!--template creates Joining instance-->
	<xsl:template name="ECRM_E85">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E85_Joining>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E85_Joining>
	</xsl:template>
	
	<!--template creates Leaving instance-->
	<xsl:template name="ECRM_E86">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E86_Leaving>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E86_Leaving>
	</xsl:template>
	
	<!--template creates Curation_Activity instance-->
	<xsl:template name="ECRM_E87">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E87_Curation_Activity>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E87_Curation_Activity>
	</xsl:template>
	
	<!--template creates Propositional_Object instance-->
	<xsl:template name="ECRM_E89">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E89_Propositional_Object>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E89_Propositional_Object>
	</xsl:template>
	
	<!--template creates Symbolic_Object instance-->
	<xsl:template name="ECRM_E90">
		<xsl:param name="URI"/>
		<xsl:param name="LBL"/>
		<xsl:param name="VAL"/>
		
		<ecrm:E90_Symbolic_Object>
			<xsl:call-template name="RDF_ABOUT"><xsl:with-param name="URI" select="$URI"/></xsl:call-template>
			<xsl:call-template name="RDFS_LABEL"><xsl:with-param name="LBL" select="$LBL"/></xsl:call-template>
			<xsl:call-template name="RDF_VALUE"><xsl:with-param name="VAL" select="$VAL"/></xsl:call-template>
		</ecrm:E90_Symbolic_Object>
	</xsl:template>
	
	<!--template implements property X is_identified_by Y & Y identifies X-->
	<!--either pass Y_URI (for rdf:resource attribute) or Y_OBJ (inline entities)-->
	<xsl:template name="ECRM_X_P1_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P1_is_identified_by rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P1i_identifies rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P1_is_identified_by>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P1_is_identified_by>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X has_type Y & Y is_type_of X-->
	<xsl:template name="ECRM_X_P2_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P2_has_type rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P2i_is_type_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P2_has_type>						
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P2_has_type>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X has_note Y (points to literal; no inverse)-->
	<xsl:template name="ECRM_X_P3_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_VAL"/>
		<xsl:param name="LANGUAGE"/>		

		<rdf:Description rdf:about="{$X_URI}">			
			<ecrm:P3_has_note>
				<xsl:if test="normalize-space($LANGUAGE) != ''">
					<xsl:attribute name="xml:lang">
						<xsl:value-of select="normalize-space($LANGUAGE)"/>
					</xsl:attribute>
				</xsl:if>			
				<xsl:value-of select="$Y_VAL"/>
			</ecrm:P3_has_note>			
		</rdf:Description>				
	</xsl:template>
	
	<!--template implements property X has_time-span Y & Y is_time-span_of X-->
	<xsl:template name="ECRM_X_P4_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P4_has_time-span rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P4i_is_time-span_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P4_has_time-span>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P4_has_time-span>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X consists_of Y & Y forms_part_of X-->
	<xsl:template name="ECRM_X_P5_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P5_consists_of rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P5i_forms_part_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P5_consists_of>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P5_consists_of>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X took_place_at Y & Y witnessed X-->
	<xsl:template name="ECRM_X_P7_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>		
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P7_took_place_at rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P7i_witnessed rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P7_took_place_at>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P7_took_place_at>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X took_place_on_or_within Y & Y witnessed X-->
	<xsl:template name="ECRM_X_P8_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P8_took_place_on_or_within rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P8i_witnessed rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P8_took_place_on_or_within>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P8_took_place_on_or_within>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X consists_of Y & Y forms_part_of X-->
	<xsl:template name="ECRM_X_P9_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P9_consists_of rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P9i_forms_part_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P9_consists_of>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P9_consists_of>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X falls_within Y & Y contains X-->
	<xsl:template name="ECRM_X_P10_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P10_falls_within rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P10i_contains rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P10_falls_within>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P10_falls_within>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X had_participant Y & Y participated_in X-->
	<xsl:template name="ECRM_X_P11_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P11_had_participant rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P11i_participated_in rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P11_had_participant>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P11_had_participant>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X occurred_in_the_presence_of Y & Y was_present_at X-->
	<xsl:template name="ECRM_X_P12_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P12_occurred_in_the_presence_of rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P12i_was_present_at rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P12_occurred_in_the_presence_of>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P12_occurred_in_the_presence_of>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X destroyed Y & Y was_destroyed_by X-->
	<xsl:template name="ECRM_X_P13_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P13_destroyed rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P13i_was_destroyed_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P13_destroyed>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P13_destroyed>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X carried_out_by Y & Y performed X-->
	<xsl:template name="ECRM_X_P14_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P14_carried_out_by rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P14i_performed rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P14_carried_out_by>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P14_carried_out_by>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X was_influenced_by Y & Y influenced X-->
	<xsl:template name="ECRM_X_P15_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P15_was_influenced_by rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P15i_influenced rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P15_was_influenced_by>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P15_was_influenced_by>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X used_specific_object Y & Y was_used_for X-->
	<xsl:template name="ECRM_X_P16_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P16_used_specific_object rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P16i_was_used_for rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P16_used_specific_object>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P16_used_specific_object>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X was_motivated_by Y & Y motivated X-->
	<xsl:template name="ECRM_X_P17_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P17_was_motivated_by rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P17i_motivated rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P17_was_motivated_by>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P17_was_motivated_by>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X was_intended_use_of Y & Y was_made_for X-->
	<xsl:template name="ECRM_X_P19_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P19_was_intended_use_of rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P19i_was_made_for rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P19_was_intended_use_of>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P19_was_intended_use_of>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X had_specific_purpose Y & Y was_purpose_of X-->
	<xsl:template name="ECRM_X_P20_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P20_had_specific_purpose rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P20i_was_purpose_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P20_had_specific_purpose>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P20_had_specific_purpose>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X had_general_purpose Y & Y was_purpose_of X-->
	<xsl:template name="ECRM_X_P21_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P21_had_general_purpose rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P21i_was_purpose_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P21_had_general_purpose>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P21_had_general_purpose>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X transferred_title_to Y & Y acquired_title_through X-->
	<xsl:template name="ECRM_X_P22_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P22_transferred_title_to rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P22i_acquired_title_through rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P22_transferred_title_to>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P22_transferred_title_to>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X transferred_title_from Y & Y surrendered_title_through X-->
	<xsl:template name="ECRM_X_P23_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P23_transferred_title_from rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P23i_surrendered_title_through rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P23_transferred_title_from>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P23_transferred_title_from>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X transferred_title_of Y & Y changed_ownership_through X-->
	<xsl:template name="ECRM_X_P24_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P24_transferred_title_of rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P24i_changed_ownership_through rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P24_transferred_title_of>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P24_transferred_title_of>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X moved Y & Y moved_by X-->
	<xsl:template name="ECRM_X_P25_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P25_moved rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P25i_moved_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P25_moved>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P25_moved>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	
	<!--template implements property X moved_to Y & Y was_destination_of X-->
	<xsl:template name="ECRM_X_P26_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P26_moved_to rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P26i_was_destination_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P26_moved_to>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P26_moved_to>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X moved_from Y & Y was_origin_of X-->
	<xsl:template name="ECRM_X_P27_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P27_moved_from rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P27i_was_origin_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P27_moved_from>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P27_moved_from>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X custody_surrendered_by Y & Y surrendered_custody_through X-->
	<xsl:template name="ECRM_X_P28_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P28_custody_surrendered_by rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P28i_surrendered_custody_through rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P28_custody_surrendered_by>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P28_custody_surrendered_by>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X custody_received_by Y & Y received_custody_through X-->
	<xsl:template name="ECRM_X_P29_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P29_custody_received_by rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P29i_received_custody_through rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P29_custody_received_by>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P29_custody_received_by>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X transferred_custody_of Y & Y custody_transferred_through X-->
	<xsl:template name="ECRM_X_P30_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P30_transferred_custody_of rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P30i_custody_transferred_through rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P30_transferred_custody_of>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P30_transferred_custody_of>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X has_modified Y & Y was_modified_by X-->
	<xsl:template name="ECRM_X_P31_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P31_has_modified rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P31i_was_modified_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P31_has_modified>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P31_has_modified>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X used_general_technique Y & Y was_technique_of X-->
	<xsl:template name="ECRM_X_P32_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P32_used_general_technique rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P32i_was_technique_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P32_used_general_technique>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P32_used_general_technique>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X used_specific_technique Y & Y was_used_by X-->
	<xsl:template name="ECRM_X_P33_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P33_used_specific_technique rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P33i_was_used_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P33_used_specific_technique>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P33_used_specific_technique>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X concerned Y & Y was_assessed_by X-->
	<xsl:template name="ECRM_X_P34_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P34_concerned rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P34i_was_assessed_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P34_concerned>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P34_concerned>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X has_identified Y & Y was_identified_by X-->
	<xsl:template name="ECRM_X_P35_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P35_has_identified rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P35i_was_identified_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P35_has_identified>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P35_has_identified>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>	

	<!--template implements property X assigned Y & Y was_assigned_by X-->
	<xsl:template name="ECRM_X_P37_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P37_assigned rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P37i_was_assigned_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P37_assigned>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P37_assigned>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X deassigned Y & Y was_deassigned_by X-->
	<xsl:template name="ECRM_X_P38_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P38_deassigned rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P38i_was_deassigned_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P38_deassigned>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P38_deassigned>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X measured Y & Y was_measured_by X-->
	<xsl:template name="ECRM_X_P39_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P39_measured rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P39i_was_measured_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P39_measured>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P39_measured>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X observed_dimension Y & Y was_observed_in X-->
	<xsl:template name="ECRM_X_P40_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P40_observed_dimension rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P40i_was_observed_in rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P40_observed_dimension>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P40_observed_dimension>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X classified Y & Y was_classified_by X-->
	<xsl:template name="ECRM_X_P41_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P41_classified rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P41i_was_classified_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P41_classified>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P41_classified>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X assigned Y & Y was_assigned_by X-->
	<xsl:template name="ECRM_X_P42_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P42_assigned rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P42i_was_assigned_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P42_assigned>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P42_assigned>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X has_dimension Y & Y is_dimension_of X-->
	<xsl:template name="ECRM_X_P43_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P43_has_dimension rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P43i_is_dimension_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P43_has_dimension>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P43_has_dimension>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X has_condition Y & Y condition_of X-->
	<xsl:template name="ECRM_X_P44_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P44_has_condition rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P44i_condition_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P44_has_condition>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P44_has_condition>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X consists_of Y & Y is_incorporated_in X-->
	<xsl:template name="ECRM_X_P45_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P45_consists_of rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P45i_is_incorporated_in rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P45_consists_of>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P45_consists_of>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X is_composed_of Y & Y forms_part_of X-->
	<xsl:template name="ECRM_X_P46_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P46_is_composed_of rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P46i_forms_part_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P46_is_composed_of>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P46_is_composed_of>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X has_preferred_identifier Y & Y is_preferred_identifier_of X-->
	<xsl:template name="ECRM_X_P48_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P48_has_preferred_identifier rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P48i_is_preferred_identifier_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P48_has_preferred_identifier>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P48_has_preferred_identifier>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X has_former_or_current_keeper Y & Y is_former_or_current_keeper_of X-->
	<xsl:template name="ECRM_X_P49_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P49_has_former_or_current_keeper rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P49i_is_former_or_current_keeper_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P49_has_former_or_current_keeper>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P49_has_former_or_current_keeper>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X has_current_keeper Y & Y is_current_keeper_of X-->
	<xsl:template name="ECRM_X_P50_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P50_has_current_keeper rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P50i_is_current_keeper_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P50_has_current_keeper>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P50_has_current_keeper>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X has_former_or_current_owner Y & Y is_former_or_current_owner_of X-->
	<xsl:template name="ECRM_X_P51_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P51_has_former_or_current_owner rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P51i_is_former_or_current_owner_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P51_has_former_or_current_owner>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P51_has_former_or_current_owner>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X has_current_owner Y & Y is_current_owner_of X-->
	<xsl:template name="ECRM_X_P52_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P52_has_current_owner rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P52i_is_current_owner_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P52_has_current_owner>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P52_has_current_owner>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X has_former_or_current_location Y & Y is_former_or_current_location_of X-->
	<xsl:template name="ECRM_X_P53_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P53_has_former_or_current_location rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P53i_is_former_or_current_location_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P53_has_former_or_current_location>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P53_has_former_or_current_location>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X has_current_permanent_location Y & Y is_current_permanent_location_of X-->
	<xsl:template name="ECRM_X_P54_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P54_has_current_permanent_location rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P54i_is_current_permanent_location_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P54_has_current_permanent_location>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P54_has_current_permanent_location>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X has_current_location Y & Y currently_holds X-->
	<xsl:template name="ECRM_X_P55_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P55_has_current_location rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P55i_currently_holds rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P55_has_current_location>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P55_has_current_location>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X bears_feature Y & Y is_found_on X-->
	<xsl:template name="ECRM_X_P56_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P56_bears_feature rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P56i_is_found_on rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P56_bears_feature>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P56_bears_feature>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X has_number_of_parts Y (points to literal; no inverse)-->
	<xsl:template name="ECRM_X_P57_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_VAL"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<ecrm:P57_has_number_of_parts>
				 <xsl:value-of select="$Y_VAL"/>		
			</ecrm:P57_has_number_of_parts> 
		</rdf:Description>
		
	</xsl:template>
	
	<!--template implements property X has_section_definition Y & Y defines_section X-->
	<xsl:template name="ECRM_X_P58_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P58_has_section_definition rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P58i_defines_section rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P58_has_section_definition>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P58_has_section_definition>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X has_section Y & Y is_located_on_or_within X-->
	<xsl:template name="ECRM_X_P59_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P59_has_section rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P59i_is_located_on_or_within rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P59_has_section>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P59_has_section>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X depicts Y & Y is_depicted_by X-->
	<xsl:template name="ECRM_X_P62_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P62_depicts rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P62i_is_depicted_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P62_depicts>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P62_depicts>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X shows_visual_item Y & Y is_shown_by X-->
	<xsl:template name="ECRM_X_P65_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P65_shows_visual_item rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P65i_is_shown_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P65_shows_visual_item>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P65_shows_visual_item>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X refers_to Y & Y is_referred_to_by X-->
	<xsl:template name="ECRM_X_P67_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P67_refers_to rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P67i_is_referred_to_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P67_refers_to>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P67_refers_to>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X foresees_use_of Y & Y use_foreseen_by X-->
	<xsl:template name="ECRM_X_P68_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P68_foresees_use_of rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P68i_use_foreseen_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P68_foresees_use_of>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P68_foresees_use_of>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements symmetric property X is_associated_with Y-->
	<xsl:template name="ECRM_X_P69_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P69_is_associated_with rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P69_is_associated_with rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P69_is_associated_with>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P69_is_associated_with>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X documents Y & Y is_documented_in X-->
	<xsl:template name="ECRM_X_P70_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P70_documents rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P70i_is_documented_in rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P70_documents>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P70_documents>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X lists Y & Y is_listed_in X-->
	<xsl:template name="ECRM_X_P71_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P71_lists rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P71i_is_listed_in rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P71_lists>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P71_lists>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X has_language Y & Y is_language_of X-->
	<xsl:template name="ECRM_X_P72_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P72_has_language rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P72i_is_language_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P72_has_language>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P72_has_language>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X has_translation Y & Y is_translation_of X-->
	<xsl:template name="ECRM_X_P73_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P73_has_translation rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P73i_is_translation_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P73_has_translation>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P73_has_translation>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X has_current_or_former_residence Y & Y is_current_or_former_residence_of X-->
	<xsl:template name="ECRM_X_P74_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P74_has_current_or_former_residence rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P74i_is_current_or_former_residence_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P74_has_current_or_former_residence>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P74_has_current_or_former_residence>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X possesses Y & Y is_possessed_by X-->
	<xsl:template name="ECRM_X_P75_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P75_possesses rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P75i_is_possessed_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P75_possesses>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P75_possesses>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X has_contact_point Y & Y provides_access_to X-->
	<xsl:template name="ECRM_X_P76_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P76_has_contact_point rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P76i_provides_access_to rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P76_has_contact_point>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P76_has_contact_point>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X is_identified_by Y & Y identifies X-->
	<xsl:template name="ECRM_X_P78_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P78_is_identified_by rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P78i_identifies rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P78_is_identified_by>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P78_is_identified_by>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X beginning_is_qualified_by Y-->
	<xsl:template name="ECRM_X_P79_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_VAL"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<ecrm:P79_beginning_is_qualified_by>
				<xsl:value-of select="$Y_VAL"/>
			</ecrm:P79_beginning_is_qualified_by>
		</rdf:Description>
		
	</xsl:template>

	<!--template implements property X end_is_qualified_by Y-->
	<xsl:template name="ECRM_X_P80_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_VAL"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<ecrm:P80_end_is_qualified_by>
				<xsl:value-of select="$Y_VAL"/>
			</ecrm:P80_end_is_qualified_by>
		</rdf:Description>
		
	</xsl:template>
	
	<!--template implements property X ongoing_throughout Y-->
	<xsl:template name="ECRM_X_P81_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_VAL"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<ecrm:P81_ongoing_throughout>
				<xsl:value-of select="$Y_VAL"/>
			</ecrm:P81_ongoing_throughout>
		</rdf:Description>
		
	</xsl:template>
	
	<!--template implements property X at_some_time_within Y-->
	<xsl:template name="ECRM_X_P82_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_VAL"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<ecrm:P82_at_some_time_within>
				<xsl:value-of select="$Y_VAL"/>
			</ecrm:P82_at_some_time_within>
		</rdf:Description>
		
	</xsl:template>

	<!--template implements property X had_at_least_duration Y & Y was_minimum_duration_of X-->
	<xsl:template name="ECRM_X_P83_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P83_had_at_least_duration rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P83i_was_minimum_duration_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P83_had_at_least_duration>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P83_had_at_least_duration>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X had_at_most_duration Y & Y was_maximum_duration_of X-->
	<xsl:template name="ECRM_X_P84_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P84_had_at_most_duration rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P84i_was_maximum_duration_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P84_had_at_most_duration>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P84_had_at_most_duration>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X falls_within Y & Y contains X-->
	<xsl:template name="ECRM_X_P86_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P86_falls_within rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P86i_contains rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P86_falls_within>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P86_falls_within>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X is_identified_by Y & Y identifies X-->
	<xsl:template name="ECRM_X_P87_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P87_is_identified_by rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P87i_identifies rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P87_is_identified_by>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P87_is_identified_by>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X consists_of Y & Y forms_part_of X-->
	<xsl:template name="ECRM_X_P88_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P88_consists_of rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P88i_forms_part_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P88_consists_of>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P88_consists_of>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X falls_within Y & Y contains X-->
	<xsl:template name="ECRM_X_P89_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P89_falls_within rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P89i_contains rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P89_falls_within>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P89_falls_within>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X has_value Y-->
	<xsl:template name="ECRM_X_P90_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_VAL"/>

		<rdf:Description rdf:about="{$X_URI}">
			<ecrm:P90_has_value>
				<xsl:value-of select="$Y_VAL"/>				
			</ecrm:P90_has_value>
		</rdf:Description>		
		
	</xsl:template>

	<!--template implements property X has_unit Y & Y is_unit_of X-->
	<xsl:template name="ECRM_X_P91_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P91_has_unit rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P91i_is_unit_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P91_has_unit>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P91_has_unit>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X brought_into_existence Y & Y was_brought_into_existence_by X-->
	<xsl:template name="ECRM_X_P92_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P92_brought_into_existence rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P92i_was_brought_into_existence_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P92_brought_into_existence>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P92_brought_into_existence>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X took_out_of_existence Y & Y was_taken_out_of_existence_by X-->
	<xsl:template name="ECRM_X_P93_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P93_took_out_of_existence rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P93i_was_taken_out_of_existence_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P93_took_out_of_existence>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P93_took_out_of_existence>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X has_created Y & Y was_created_by X-->
	<xsl:template name="ECRM_X_P94_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P94_has_created rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P94i_was_created_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P94_has_created>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P94_has_created>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X has_formed Y & Y was_formed_by X-->
	<xsl:template name="ECRM_X_P95_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P95_has_formed rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P95i_was_formed_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P95_has_formed>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P95_has_formed>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X by_mother Y & Y gave_birth X-->
	<xsl:template name="ECRM_X_P96_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P96_by_mother rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P96i_gave_birth rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P96_by_mother>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P96_by_mother>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X from_father Y & Y was_father_for X-->
	<xsl:template name="ECRM_X_P97_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P97_from_father rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P97i_was_father_for rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P97_from_father>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P97_from_father>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X brought_into_life Y & Y was_born X-->
	<xsl:template name="ECRM_X_P98_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P98_brought_into_life rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P98i_was_born rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P98_brought_into_life>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P98_brought_into_life>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X dissolved Y & Y was_dissolved_by X-->
	<xsl:template name="ECRM_X_P99_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P99_dissolved rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P99i_was_dissolved_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P99_dissolved>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P99_dissolved>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X was_death_of Y & Y died_in X-->
	<xsl:template name="ECRM_X_P100_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P100_was_death_of rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P100i_died_in rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P100_was_death_of>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P100_was_death_of>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X had_as_general_use Y & Y was_use_of X-->
	<xsl:template name="ECRM_X_P101_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P101_had_as_general_use rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P101i_was_use_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P101_had_as_general_use>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P101_had_as_general_use>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
		
	<!--template implements property X has_title Y & Y is_title_of X-->
	<xsl:template name="ECRM_X_P102_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P102_has_title rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P102i_is_title_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P102_has_title>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P102_has_title>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>	

	<!--template implements property X was_intended_for Y & Y was_intention_of X-->
	<xsl:template name="ECRM_X_P103_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P103_was_intended_for rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P103i_was_intention_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P103_was_intended_for>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P103_was_intended_for>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X is_subject_to Y & Y applies_to X-->
	<xsl:template name="ECRM_X_P104_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P104_is_subject_to rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P104i_applies_to rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P104_is_subject_to>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P104_is_subject_to>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>	
	</xsl:template>

	<!--template implements property X right_held_by Y & Y has_right_on X-->
	<xsl:template name="ECRM_X_P105_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P105_right_held_by rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P105i_has_right_on rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P105_right_held_by>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P105_right_held_by>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>	
	</xsl:template>
	
	<!--template implements property X is_composed_of Y & Y forms_part_of X-->
	<xsl:template name="ECRM_X_P106_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P106_is_composed_of rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P106i_forms_part_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P106_is_composed_of>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P106_is_composed_of>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X has_current_or_former_member Y & Y is_current_or_former_member_of X-->
	<xsl:template name="ECRM_X_P107_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P107_has_current_or_former_member rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P107i_is_current_or_former_member_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P107_has_current_or_former_member>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P107_has_current_or_former_member>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X has_produced Y & Y was_produced_by X-->
	<xsl:template name="ECRM_X_P108_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P108_has_produced rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P108i_was_produced_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P108_has_produced>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P108_has_produced>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X has_current_or_former_curator Y & Y is_current_or_former_curator_of X-->
	<xsl:template name="ECRM_X_P109_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P109_has_current_or_former_curator rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P109i_is_current_or_former_curator_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P109_has_current_or_former_curator>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P109_has_current_or_former_curator>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X augmented Y & Y was_augmented_by X-->
	<xsl:template name="ECRM_X_P110_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P110_augmented rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P110i_was_augmented_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P110_augmented>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P110_augmented>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X added Y & Y was_added_by X-->
	<xsl:template name="ECRM_X_P111_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P111_added rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P111i_was_added_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P111_added>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P111_added>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X diminished Y & Y was_diminished_by X-->
	<xsl:template name="ECRM_X_P112_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P112_diminished rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P112i_was_diminished_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P112_diminished>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P112_diminished>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X removed Y & Y was_removed_by X-->
	<xsl:template name="ECRM_X_P113_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P113_removed rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P113i_was_removed_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P113_removed>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P113_removed>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements symmetric property X is_equal_in_time_to Y-->
	<xsl:template name="ECRM_X_P114_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P114_is_equal_in_time_to rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P114_is_equal_in_time_to rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P114_is_equal_in_time_to>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P114_is_equal_in_time_to>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X finishes Y & Y is_finished_by X-->
	<xsl:template name="ECRM_X_P115_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P115_finishes rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P115i_is_finished_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P115_finishes>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P115_finishes>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X starts Y & Y is_started_by X-->
	<xsl:template name="ECRM_X_P116_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P116_starts rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P116i_is_started_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P116_starts>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P116_starts>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X occurs_during Y & Y includes X-->
	<xsl:template name="ECRM_X_P117_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P117_occurs_during rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P117i_includes rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P117_occurs_during>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P117_occurs_during>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X overlaps_in_time_with Y & Y is_overlapped_in_time_by X-->
	<xsl:template name="ECRM_X_P118_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P118_overlaps_in_time_with rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P118i_is_overlapped_in_time_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P118_overlaps_in_time_with>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P118_overlaps_in_time_with>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X meets_in_time_with Y & Y is_met_in_time_by X-->
	<xsl:template name="ECRM_X_P119_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P119_meets_in_time_with rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P119i_is_met_in_time_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P119_meets_in_time_with>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P119_meets_in_time_with>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X occurs_before Y & Y occurs_after X-->
	<xsl:template name="ECRM_X_P120_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P120_occurs_before rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P120i_occurs_after rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P120_occurs_before>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P120_occurs_before>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>	
	
	<!--template implements symmetric property X overlaps_with Y-->
	<xsl:template name="ECRM_X_P121_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P121_overlaps_with rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P121_overlaps_with rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P121_overlaps_with>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P121_overlaps_with>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>	

	<!--template implements symmetric property X borders_with Y-->
	<xsl:template name="ECRM_X_P122_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P122_borders_with rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P122_borders_with rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P122_borders_with>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P122_borders_with>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>	

	<!--template implements property X resulted_in Y & Y resulted_from X-->
	<xsl:template name="ECRM_X_P123_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P123_resulted_in rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P123i_resulted_from rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P123_resulted_in>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P123_resulted_in>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>	
	
	<!--template implements property X transformed Y & Y was_transformed_by X-->
	<xsl:template name="ECRM_X_P124_Y">	
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P124_transformed rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P124i_was_transformed_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P124_transformed>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P124_transformed>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>	

	<!--template implements property X used_object_of_type Y & Y was_type_of_object_used_in X-->
	<xsl:template name="ECRM_X_P125_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P125_used_object_of_type rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P125i_was_type_of_object_used_in rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P125_used_object_of_type>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P125_used_object_of_type>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>	
	
	<!--template implements property X employed Y & Y was_employed_in X-->
	<xsl:template name="ECRM_X_P126_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P126_employed rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P126i_was_employed_in rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P126_employed>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P126_employed>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>	
	
	<!--template implements property X has_broader_term Y & Y has_narrower_term X-->
	<xsl:template name="ECRM_X_P127_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P127_has_broader_term rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P127i_has_narrower_term rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P127_has_broader_term>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P127_has_broader_term>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X carries Y & Y is_carried_by X-->
	<xsl:template name="ECRM_X_P128_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P128_carries rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P128i_is_carried_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P128_carries>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P128_carries>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X is_about Y & Y is_subject_of X-->
	<xsl:template name="ECRM_X_P129_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P129_is_about rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P129i_is_subject_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P129_is_about>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P129_is_about>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X shows_features_of Y & Y features_are_also_found_on X-->
	<xsl:template name="ECRM_X_P130_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P130_shows_features_of rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P130i_features_are_also_found_on rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P130_shows_features_of>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P130_shows_features_of>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X is_identified_by Y & Y identifies X-->
	<xsl:template name="ECRM_X_P131_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P131_is_identified_by rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P131i_identifies rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P131_is_identified_by>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P131_is_identified_by>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements symmetric property X overlaps_with Y-->
	<xsl:template name="ECRM_X_P132_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P132_overlaps_with rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P132_overlaps_with rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P132_overlaps_with>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P132_overlaps_with>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements symmetric property X is_separated_from Y-->
	<xsl:template name="ECRM_X_P133_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P133_is_separated_from rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P133_is_separated_from rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P133_is_separated_from>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P133_is_separated_from>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X continued Y & Y was_continued_by X-->
	<xsl:template name="ECRM_X_P134_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P134_continued rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P134i_was_continued_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P134_continued>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P134_continued>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X created_type Y & Y was_created_by X-->
	<xsl:template name="ECRM_X_P135_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P135_created_type rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P135i_was_created_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P135_created_type>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P135_created_type>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X was_based_on Y & Y supported_type_creation X-->
	<xsl:template name="ECRM_X_P136_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P136_was_based_on rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P136i_supported_type_creation rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P136_was_based_on>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P136_was_based_on>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X  exemplifies Y & Y is_exemplified_by X-->
	<xsl:template name="ECRM_X_P137_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P137_exemplifies rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P137i_is_exemplified_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P137_exemplifies>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P137_exemplifies>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X represents Y & Y has_representation X-->
	<xsl:template name="ECRM_X_P138_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P138_represents rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P138i_has_representation rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P138_represents>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P138_represents>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements symmetric property X has_alternative_form Y-->
	<xsl:template name="ECRM_X_P139_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P139_has_alternative_form rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P139_has_alternative_form rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P139_has_alternative_form>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P139_has_alternative_form>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X assigned_attribute_to Y & Y was_attributed_by X-->
	<xsl:template name="ECRM_X_P140_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P140_assigned_attribute_to rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P140i_was_attributed_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P140_assigned_attribute_to>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P140_assigned_attribute_to>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X assigned Y & Y was_assigned_by X-->
	<xsl:template name="ECRM_X_P141_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P141_assigned rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P141i_was_assigned_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P141_assigned>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P141_assigned>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
		
	<!--template implements property X used_constituent Y & Y was_used_in X-->
	<xsl:template name="ECRM_X_P142_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P142_used_constituent rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P142i_was_used_in rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P142_used_constituent>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P142_used_constituent>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X joined Y & Y was_joined_by X-->
	<xsl:template name="ECRM_X_P143_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P143_joined rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P143i_was_joined_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P143_joined>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P143_joined>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X joined_with Y & Y gained_member_by X-->
	<xsl:template name="ECRM_X_P144_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P144_joined_with rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P144i_gained_member_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P144_joined_with>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P144_joined_with>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X separated Y & Y left_by X-->
	<xsl:template name="ECRM_X_P145_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P145_separated rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P145i_left_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P145_separated>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P145_separated>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X separated_from Y & Y lost_member_by X-->
	<xsl:template name="ECRM_X_P146_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P146_separated_from rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P146i_lost_member_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P146_separated_from>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P146_separated_from>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>

	<!--template implements property X curated Y & Y was_curated_by X-->
	<xsl:template name="ECRM_X_P147_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P147_curated rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P147i_was_curated_by rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P147_curated>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P147_curated>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<!--template implements property X has_component Y & Y is_component_of X-->
	<xsl:template name="ECRM_X_P148_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		<xsl:param name="Y_OBJ"/>
		
		<xsl:choose>
			<xsl:when test="normalize-space($Y_URI) != ''">
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P148_has_component rdf:resource="{$Y_URI}"/>
				</rdf:Description>
				<rdf:Description rdf:about="{$Y_URI}">
					<ecrm:P148i_is_component_of rdf:resource="{$X_URI}"/>
				</rdf:Description>
			</xsl:when>
			<xsl:otherwise>
				<rdf:Description rdf:about="{$X_URI}">
					<ecrm:P148_has_component>
						<xsl:copy-of select="$Y_OBJ"/>
					</ecrm:P148_has_component>
				</rdf:Description>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	
	<xsl:template name="abs">   
		<xsl:param name="number"/>  
		<xsl:value-of select="($number >= 0) * $number - not($number >= 0) * $number"/>	
	</xsl:template>
	
	
	
</xsl:stylesheet>
