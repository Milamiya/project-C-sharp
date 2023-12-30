<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <!-- xmlns="http://www.w3.org/TR/xhtml1/strict" -->
    <!--
        @description: The stylesheet does display a table
        for modifing a permission.
    -->
    <xsl:template name="doPermission">
        <xsl:for-each select="//permissions">
            <xsl:variable name="perid">
                <xsl:value-of select="maper" />
            </xsl:variable>
            <tr>
                <td><font face="VNI-Times"><xsl:value-of select="@stt" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="maper" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="tenper" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="ghichu" /></font></td>
                <td><a href="preparePermission.jsp?perid={$perid}"><font face="VNI-Times">Söûa</font></a></td>
            </tr>
        </xsl:for-each>
    </xsl:template>
    <xsl:template match="/">
        <table border="1" width="100%">
            <tr bgcolor="#DDECEE">
                <th><font face="VNI-Times" color="#003366">STT</font></th>
                <th><font face="VNI-Times" color="#003366">Maõ Quyeàn</font></th>
                <th><font face="VNI-Times" color="#003366">Teân Quyeàn</font></th>
                <th><font face="VNI-Times" color="#003366">Ghi Chuù</font></th>
                <th><font face="VNI-Times" color="#003366">&#160;&#160;&#160;</font></th>
            </tr>
            <xsl:call-template name="doPermission" />
        </table>
    </xsl:template>
</xsl:stylesheet>