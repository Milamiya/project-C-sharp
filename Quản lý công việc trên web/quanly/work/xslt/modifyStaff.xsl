<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <!-- xmlns="http://www.w3.org/TR/xhtml1/strict" -->
    <!--
        @description: The stylesheet does display a table
        for modifing a staff.
    -->
    <xsl:template name="doStaff">
        <xsl:for-each select="//nhanvien">
            <xsl:variable name="staffid">
                <xsl:value-of select="manv" />
            </xsl:variable>
            <tr>
                <td><font face="VNI-Times"><xsl:value-of select="@stt" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="manv" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="tennv" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="magroup" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="ngaysinh" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="diachi" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="phone" /></font></td>
                <td><a href="prepareStaff.jsp?staffid={$staffid}"><font face="VNI-Times">Söûa</font></a></td>
            </tr>
        </xsl:for-each>
    </xsl:template>
    <xsl:template match="/"> <!-- Root document: congviec -->
        <table border="1" width="100%">
            <tr bgcolor="#DDECEE">
                <th><font face="VNI-Times" color="#003366">STT</font></th>
                <th><font face="VNI-Times" color="#003366">Maõ NV</font></th>
                <th><font face="VNI-Times" color="#003366">Teân NV</font></th>
                <th><font face="VNI-Times" color="#003366">Thuoäc Nhoùm</font></th>
                <th><font face="VNI-Times" color="#003366">Ngaøy Sinh</font></th>
                <th><font face="VNI-Times" color="#003366">Ñòa Chæ</font></th>
                <th><font face="VNI-Times" color="#003366">Ñieän Thoaïi</font></th>
                <th><font face="VNI-Times" color="#003366">&#160;&#160;&#160;</font></th>
            </tr>
            <xsl:call-template name="doStaff" />
        </table>
    </xsl:template>
</xsl:stylesheet>