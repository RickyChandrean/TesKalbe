<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="study.aspx.cs" Inherits="TesKalbe.study" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tes Kalbe</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
	<script src="Scripts/jquery-3.4.1.js"></script>
	<script src="Scripts/bootstrap.js"></script>

</head>
<body>
	<ul class="nav nav-tabs">
			<li>
				<a class="nav-link active" href="#insert" data-toggle="tab">Study Status</a>
			</li>
			<li>
				<a class="nav-link" href="#display" data-toggle="tab">Molecules</a>
			</li>
		</ul> 
	<form runat="server">
		<div class="tab-content">
			<div id="insert" class="tab-pane active" >
				<asp:Literal ID="response" runat="server"></asp:Literal>
				<div class="form-group">
					<asp:Label ID="Label1" runat="server" Text="Study ID"></asp:Label>
					<asp:TextBox ID="txtStudyId" runat="server" CssClass="form-control" placeholder="Enter Study ID" required="true"></asp:TextBox>
				</div>
				<div class="form-group">
					<asp:Label ID="Label2" runat="server" Text="Version ID" for="txNama"></asp:Label>
					<asp:TextBox ID="txtVersionId" runat="server" class="form-control" placeholder="Enter Version Id" required="true"></asp:TextBox>
				</div>
				<div class="form-group">
					<asp:Label ID="Label3" runat="server" Text="Protocol Title" for="txprotocTitle"></asp:Label>
					<asp:TextBox ID="txtProtocolTitle" runat="server" class="form-control" placeholder="Enter Protocol Title" required="true"></asp:TextBox>
				</div>
				<div class="form-group">
					<asp:Label ID="Label4" runat="server" Text="Protocol Code" for="txNama"></asp:Label>
					<asp:TextBox ID="txtProtocolCode" runat="server" class="form-control" placeholder="Enter Protocol Code" required="true"></asp:TextBox>
				</div>
				<div class="form-group">
					<asp:Label ID="Label5" runat="server" Text="Molecules ID" for="txNama"></asp:Label>
					<asp:TextBox ID="txtMoleculesId" runat="server" class="form-control" placeholder="Enter Molecules ID" required="true"></asp:TextBox>
				</div>
				<div class="form-group">
					<asp:Label ID="Label6" runat="server" Text="Study Status ID" for="txNama"></asp:Label>
					<asp:TextBox ID="txtStudyStatusID" runat="server" class="form-control" placeholder="Enter Study Status ID" required="true"></asp:TextBox>
				</div>
				<div class="form-group">
					<asp:Label ID="Label7" runat="server" Text="Created By" for="txNama"></asp:Label>
					<asp:TextBox ID="txtCreatedBy" runat="server" class="form-control" placeholder="Enter Name" required="true"></asp:TextBox>
				</div>
				<div class="form-group">
					<asp:Label ID="Label8" runat="server" Text="State" for="State"></asp:Label>
					<asp:TextBox ID="txtState" runat="server" class="form-control" placeholder="Enter State" required="true"></asp:TextBox>
				</div>
				<br />
				<asp:Button ID="btnSimpan" runat="server" Text="Simpan" CssClass="btn btn-primary" OnClick="btnSimpan_Click" />	
			</div>

			<div id="display" class="tab-pane" >
				<asp:Literal ID="lt_table" runat="server"></asp:Literal>
			</div>
		</div>
		</form>
</body>
</html>
