#pragma checksum "C:\Users\20795\Desktop\软件实训开发大作业\MVC---FinalProject\TZstore\TZstore\Views\Product\EditOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4af068370aa6918804f5dfeaedb2c6ab3adbb697"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_EditOrder), @"mvc.1.0.view", @"/Views/Product/EditOrder.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\20795\Desktop\软件实训开发大作业\MVC---FinalProject\TZstore\TZstore\Views\_ViewImports.cshtml"
using TZstore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\20795\Desktop\软件实训开发大作业\MVC---FinalProject\TZstore\TZstore\Views\_ViewImports.cshtml"
using TZstore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4af068370aa6918804f5dfeaedb2c6ab3adbb697", @"/Views/Product/EditOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2ae085459a130b9f395fb5d49c1cc3b0e32c6b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_EditOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 0;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4af068370aa6918804f5dfeaedb2c6ab3adbb6973655", async() => {
                WriteLiteral("\r\n    <title>修改订单页面</title>\r\n    <meta charset=\"UTF-8\" />\r\n    <!-- import CSS -->\r\n    <link href=\"https://unpkg.com/element-ui/lib/theme-chalk/index.css\"\r\n          rel=\"stylesheet\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4af068370aa6918804f5dfeaedb2c6ab3adbb6974823", async() => {
                WriteLiteral(@"
    <el-container id=""app"" style=""height:800px; background-color: rgb(0, 183, 255);"">
        <el-main>
            <el-row>
                <el-col :span=""12"" offset=""6"">
                    <el-card class=""box-card"" style=""height: 450px;"">
                        <el-form :model=""product""
                                 label-width=""auto""
                                 ref=""form"">
                            <el-row>
                                <el-col>
                                    <el-form-item label=""订单编号"">
                                        <el-input :disabled=""true""
                                                  v-model=""order.orderNumber"">
                                        </el-input>
                                    </el-form-item>
                                </el-col>
                            </el-row>
                            <el-row>
                                <el-col>
                                    <el-form-item label=""产品名称"">");
                WriteLiteral(@"
                                        <el-input :disabled=""true""
                                                  v-model=""order.productName"">
                                        </el-input>
                                    </el-form-item>
                                </el-col>
                            </el-row>
                            <el-row>
                                <el-col>
                                    <el-form-item label=""收货人"">
                                        <el-input :disabled=""true""
                                                  v-model=""order.userName"">
                                        </el-input>
                                    </el-form-item>
                                </el-col>
                            </el-row>
                            <el-row>
                                <el-col>
                                    <el-form-item label=""联系电话"">
                                        <el-input :disabled=""true");
                WriteLiteral(@"""
                                                  v-model=""order.userphone"">
                                        </el-input>
                                    </el-form-item>
                                </el-col>
                            </el-row>
                            <el-row>
                                <el-col>
                                    <el-form-item label=""收货地址"">
                                        <el-input :disabled=""true""
                                                  v-model=""order.useraddress"">
                                        </el-input>
                                    </el-form-item>
                                </el-col>
                            </el-row>
                            <el-row>
                                <el-col>
                                    <el-form-item label=""订单状态"">
                                        <el-radio v-model=""order.orderState"" label=""已下单"">已下单</el-radio>
                        ");
                WriteLiteral(@"                <el-radio v-model=""order.orderState"" label=""出餐中"">出餐中</el-radio>
                                        <el-radio v-model=""order.orderState"" label=""骑手已取餐"">骑手已取餐</el-radio>
                                        <el-radio v-model=""order.orderState"" label=""配送中"">配送中</el-radio>
                                        <el-radio v-model=""order.orderState"" label=""已送达"">已送达</el-radio>
                                    </el-form-item>
                                </el-col>
                            </el-row>
                            <el-row>
                                <el-col style=""text-align: center;"">
                                    <el-form-item>
                                        <el-button type=""primary""
                                                   v-on:click=""onOKButtonClick"">
                                            确认修改
                                        </el-button>
                                        <el-button v-on:click=""onBackButtonC");
                WriteLiteral(@"lick"">返回</el-button>
                                    </el-form-item>
                                </el-col>
                            </el-row>
                        </el-form>
                    </el-card>
                </el-col>
            </el-row>
        </el-main>
    </el-container>
    <!-- import Vue before Element -->
    <script src=""https://unpkg.com/vue/dist/vue.js""></script>
    <!-- import JavaScript -->
    <script src=""https://unpkg.com/element-ui/lib/index.js""></script>
    <script src=""https://cdn.bootcdn.net/ajax/libs/axios/0.19.2/axios.js""></script>
    <script>
    const app = new Vue({
        el: ""#app"",
        data: {
            order:{}
        },
        methods: {
            //返回后台首页
            onBackButtonClick() {
                window.location.href = ""/Product/Index"";
            },
            async onOKButtonClick() {
                let response = await axios.post('/Product/UpdateOrder', this.order);
                if (response");
                WriteLiteral(@".data.code === 'success') {
                    this.$message({
                        message: '记录修改成功',
                        type: 'success'
                    });

                    window.location.href = ""/Product/OrderTable"";
                } else {
                    this.$message({
                        message: '记录修改失败',
                        type: 'error'
                    });
                }
            }, 
            async getOrderById(id) {
                let response = await axios.get('/Product/getOrderById', { params: { id: id } });
                if (response.data.code === 'success') {
                    //绑定查找出来的数据
                    this.order = response.data.data;
                }
            },
            //用于界面的安全防止非管理员直接用URl
            async LoginAndAdmin() {

                //用于判断用户有没有登录并且时不时管理员
                let response = await axios.get('/User/LoginAndAdmin');
                if (response.data.code === 'success') {

             ");
                WriteLiteral(@"   } else if (response.data.code === 'NoAdmin') {
                    this.$confirm('您不是管理员',
                        '提示',
                        {
                            confirmButtonText: '确定',
                            cancelButtonText: '取消',
                            type: 'warning'
                        })
                        .then(async () => {
                            //返回用户前台
                            window.location.href = ""/User/Index"";
                            //await this.deleteProduct(id);
                        })
                        .catch(() => {
                            //返回用户前台
                            window.location.href = ""/User/Index"";
                        });
                }
                else {
                    this.$confirm('您还未登录',
                        '提示',
                        {
                            confirmButtonText: '确定',
                            cancelButtonText: '取消',
                         ");
                WriteLiteral(@"   type: 'warning'
                        })
                        .then(async () => {
                            //返回用户前台
                            window.location.href = ""/User/Index"";
                            //await this.deleteProduct(id);
                        })
                        .catch(() => {
                            //返回用户前台
                            window.location.href = ""/User/Index"";
                        });
                }
            }
        },
        mounted() {
            this.getOrderById(");
#nullable restore
#line 177 "C:\Users\20795\Desktop\软件实训开发大作业\MVC---FinalProject\TZstore\TZstore\Views\Product\EditOrder.cshtml"
                         Write(ViewBag.id);

#line default
#line hidden
#nullable disable
                WriteLiteral(");\r\n            //用于防止非法用户直接用URL\r\n            this.LoginAndAdmin();\r\n        }\r\n    });\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
