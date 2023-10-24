<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:a="http://tempuri.org/KhoaType.xsd"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
      <html>
        <head>
          <title>Danh sách bệnh nhân</title>
        </head>
        
        <body>
	        <xsl:for-each select="a:DSBN/a:Khoa">
          <table border="0">
            <tr>
              <td>BỆNH VIỆN ĐA KHOA</td>
              <th>DANH SÁCH BỆNH NHÂN</th>
            </tr>
            <tr>
              <td>
                Khoa: <xsl:value-of select="@tenkhoa"/>
              </td>
          </tr>
          </table>
          <table border="2" cellpading="3">
            <tr>
              <td>STT</td>
              <td>Họ tên</td>
              <td>Ngày nhập viện</td>
              <td>Số ngày điều trị</td>
              <td>Số tiền phải trả</td>
            </tr>
            <xsl:for-each select="a:HSBN">
              <tr>
                <td>
                  <xsl:value-of select="position()"/>
                </td>
                <td>
                  <xsl:value-of select="a:hoten"/>
                </td>
                <td>
                  <xsl:value-of select="a:ngaynhapvien"/>
                </td>
                <td>
                  <xsl:value-of select="a:songaynamvien"/>
                </td>
                <td>
                  <xsl:value-of select="a:songaynamvien * 15000"/>
                </td>
              </tr>
            </xsl:for-each>
          </table>
	</xsl:for-each>
        </body>
        
      </html>
    </xsl:template>
</xsl:stylesheet>
