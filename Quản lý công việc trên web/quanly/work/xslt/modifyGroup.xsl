<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <!-- xmlns="http://www.w3.org/TR/xhtml1/strict" -->
    <!--
        @description: The stylesheet does display a table
        for modifing a permission.
    -->
    <xsl:template name="doGroup">
        <xsl:for-each select="//groups">
            <xsl:variable name="groupid">
                <xsl:value-of select="magroup" />
            </xsl:variable>
            <tr>
                <td><font face="VNI-Times"><xsl:value-of select="@stt" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="magroup" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="tengroup" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="trggroup" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="ngaync" /></font></td>
                <td><a href="prepareGroup.jsp?groupid={$groupid}"><font face="VNI-Times">Söûa</font></a></td>
            </tr>
        </xsl:for-each>
    </xsl:template>
    <xsl:template match="/"> <!-- Root document: congviec -->
        <table border="1" width="100%">
            <tr bgcolor="#DDECEE">
                <th><font face="VNI-Times" color="#003366">STT</font></th>
                <th><font face="VNI-Times" color="#003366">Maõ Nhoùm</font></th>
                <th><font face="VNI-Times" color="#003366">Teân Nhoùm</font></th>
                <th><font face="VNI-Times" color="#003366">Tröôûng Nhoùm</font></th>
                <th><font face="VNI-Times" color="#003366">Ngaøy Nhaän Chöùc</font></th>
                <th><font face="VNI-Times" color="#003366">&#160;&#160;&#160;</font></th>
            </tr>
            <xsl:call-template name="doGroup" />
        </table>
    </xsl:template>
</xsl:stylesheet>