<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0"
   xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="/">
		<html>
			<body>
				<h2>Archive</h2>
				<table border="1">
					<tr>
						<th>Material</th>
						<th>Faculty</th>
						<th>Cathedry</th>
						<th>Material Type</th>
						<th>Pages</th>
						<th>Date</th>
					</tr>
					<xsl:for-each select="//masterpiece">
						<tr>
							<td>
								<xsl:value-of select="@MATERIAL"/>
							</td>
							<td>
								<xsl:value-of select="@FACULTY"/>
							</td>
							<td>
								<xsl:value-of select="@CATHEDRY"/>
							</td>
							<td>
								<xsl:value-of select="@MATERIAL_TYPE"/>
							</td>
							<td>
								<xsl:value-of select="@PAGES"/>
							</td>
							<td>
								<xsl:value-of select="@DATE"/>
							</td>
						</tr>
					</xsl:for-each>		
				</table>
			</body>
		</html>
	</xsl:template>

</xsl:stylesheet>