<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="QLMonhoc.aspx.cs" Inherits="WebQLDaoTao.QLMonhoc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <h4>Thiết kế giao diện cho trang quản lý môn học</h4>
    <div>
        <asp:GridView ID="gvMonHoc" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-hover">
           <Columns>
                <asp:BoundField HeaderText="Mã môn học" DataField="MaMH" />
                <asp:BoundField HeaderText="Tên môn học" DataField="TenMH" />
                <asp:BoundField HeaderText="Số tiết"   DataField="SoTiet" />
           </Columns>
        </asp:GridView >
        <HeaderStyle BackColor="#093399" ForeColor="#ffffff" />
    </div>
</asp:Content>
