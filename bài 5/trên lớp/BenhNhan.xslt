<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:a="http://tempuri.org/XMLSchema.xsd">
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<head>
				<title>Danh sách bệnh nhân</title>
			</head>
			<xsl:for-each select="a:BVDK/a:Khoa">
				<body>
					<table border="0" cellpadding="7px">
						<tr>
							<td align="left" width="300px">BỆNH VIỆN ĐA KHOA</td>
							<th align="center">DANH SÁCH BỆNH NHÂN</th>
						</tr>
						<tr>
							<td>
								Khoa: <xsl:value-of select="a:TenKhoa"/>
							</td>
							<td>
								Phòng: <xsl:value-of select="a:Phong"/>
							</td>
						</tr>
					</table>
					<table border="1" style="border-collapse: collapse;" cellpadding="5px">
						<tr>
							<td>Mã số BN</td>
							<td>Họ tên</td>
							<td>Ngày nhập viện</td>
							<td>Số ngày điều trị</td>
							<td>Số tiền phải trả</td>
						</tr>
						<xsl:for-each select="a:BenhNhan">
							<tr>
								<td>
									<xsl:value-of select="@MasoBN"></xsl:value-of>
								</td>
								<td>
									<xsl:value-of select="a:HoTen"/>
								</td>
								<td>
									<xsl:value-of select="a:NgayNhapVien"/>
								</td>
								<td>
									<xsl:value-of select="a:NgayDieuTri"/>
								</td>
								<td>
									<xsl:value-of select="a:NgayDieuTri * 15000"/>
								</td>
							</tr>
						</xsl:for-each>
					</table>
				</body>
			</xsl:for-each>
		</html>
    </xsl:template>
</xsl:stylesheet>
