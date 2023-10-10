<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:b="http://tempuri.org/XMLSchema.xsd"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output method="html" indent="yes"/>

  <xsl:template match="/">
    <html>
      <head>
        <title>Bài thực hành 2</title>
      </head>
      <body>
        <h2>Truy vấn những sinh viên học THVP có điểm thi >= 5</h2>
        <table border="1" cellpadding="10px">
          <tr>
            <th width="170px" align="left">MaSv</th>
            <th width="200px" align="left">MaMh</th>
            <th width="250px" align="left">DiemThi</th>
          </tr>
          <xsl:for-each select="b:KetQua/b:Diem[b:MaMh = 'THVP' and b:DiemThi &gt;= 5]">
            <xsl:sort select="b:DiemThi" order="ascending"/>
            <tr>
              <td>
                <xsl:value-of select="b:MaSv"/>
              </td>
              <td>
                <xsl:value-of select="b:MaMh"/>
              </td>
              <td>
                <xsl:value-of select="b:DiemThi"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
