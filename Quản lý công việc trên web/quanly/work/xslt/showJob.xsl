<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <!-- xmlns="http://www.w3.org/TR/xhtml1/strict" -->
    <!--
        @description: The stylesheet does transform a XML
        document to a HTML table for showing jobs.
    -->
    <xsl:template match="/"> <!-- Root document: congviec -->
        <table border="1" width="100%">
            <tr bgcolor="#DDECEE">
                <th><font face="VNI-Times" color="#003366">STT</font></th>
                <th><font face="VNI-Times" color="#003366">Ma� CV</font></th>
                <th><font face="VNI-Times" color="#003366">Te�n CV</font></th>
                <th><font face="VNI-Times" color="#003366">No�i Dung</font></th>
                <th><font face="VNI-Times" color="#003366">Thuo�c �e� A�n</font></th>
                <th><font face="VNI-Times" color="#003366">Hoa�n Tha�nh?</font></th>
            </tr>
            <xsl:for-each select="//works">
                <tr>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./@stt" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./macv" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./tencv" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./noidung" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./tenda" /></font></td>
                    <xsl:choose>
                        <xsl:when test="./daxong=0">
                            <td align="center"><font face="VNI-Times">Ch�a</font></td>
                        </xsl:when>
                        <xsl:otherwise>
                            <td align="center"><font face="VNI-Times">Ro�i</font></td>
                        </xsl:otherwise>
                    </xsl:choose>
                </tr>
            </xsl:for-each>
        </table>
    </xsl:template>
</xsl:stylesheet>