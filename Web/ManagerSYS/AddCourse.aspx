<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="AddCourse.aspx.cs" Inherits="Web.AddCourse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/AddStu_Style.css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="right01">
        <img src="images/04.gif" />
        课程管理 &gt; 
		<span>添加课程</span>
    </div>
    <div class="content">
        <div class="AddStu_contend_body">
            <h2 class="content_h2">添加课程</h2>
            <p class="content_p">请填写课程信息</p>
            <div class="content_formdiv">
                <table class="content_table">
                    <tr>
                        <td align="right">课程名称:</td>
                        <td>
                            <asp:TextBox ID="txt_CName" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">学分:</td>
                        <td>
                            <asp:DropDownList ID="DDL_Credit" runat="server" Width="204px" OnSelectedIndexChanged="DDL_Credit_SelectedIndexChanged">
                                <asp:ListItem Selected="True">0.25</asp:ListItem>
                                <asp:ListItem>0.5</asp:ListItem>
                                <asp:ListItem>1.5</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>2.5</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>3.5</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>4.5</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                                <asp:ListItem>5.5</asp:ListItem>
                                <asp:ListItem>6</asp:ListItem>
                                <asp:ListItem>6.5</asp:ListItem>
                                <asp:ListItem>7</asp:ListItem>
                                <asp:ListItem>7.5</asp:ListItem>
                                <asp:ListItem>8</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">学时:</td>
                        <td>
                            <asp:DropDownList ID="DDL_Period" runat="server" Width="204px" OnSelectedIndexChanged="DDL_Period_SelectedIndexChanged">
                                <asp:ListItem Selected="True">4</asp:ListItem>
                                <asp:ListItem>8</asp:ListItem>
                                <asp:ListItem>12</asp:ListItem>
                                <asp:ListItem>16</asp:ListItem>
                                <asp:ListItem>20</asp:ListItem>
                                <asp:ListItem>24</asp:ListItem>
                                <asp:ListItem>32</asp:ListItem>
                                <asp:ListItem>48</asp:ListItem>
                                <asp:ListItem>64</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">开始时间:</td>
                        <td>
                            <asp:TextBox ID="txt_StartTime" runat="server" Width="200px" TextMode="Date"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td align="right">开设专业：
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_CourseSp" runat="server" Width="204px" OnSelectedIndexChanged="DDL_CourseSp_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">课程类型：
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_Species" runat="server" Width="204px" OnSelectedIndexChanged="DDL_Species_SelectedIndexChanged">
                                <asp:ListItem Selected="True">必修</asp:ListItem>
                                <asp:ListItem>选修</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">上课地点：</td>
                        <td>
                            <asp:TextBox ID="txt_CLocation" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">授课教师：
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_CTeacher" runat="server" Width="204px" OnSelectedIndexChanged="DDL_CTeacher_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" align="center">
                            <asp:Button ID="btn_AddCourse" runat="server" Text="添加" CssClass="btn" OnClick="btn_AddCourse_Click" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
