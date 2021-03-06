#pragma checksum "C:\Users\20795\Desktop\软件实训开发大作业\MVC---FinalProject\TZstore\TZstore\Views\Product\OrderTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41f471d7b7847bd190e51cfe5697c311fd4d02b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_OrderTable), @"mvc.1.0.view", @"/Views/Product/OrderTable.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41f471d7b7847bd190e51cfe5697c311fd4d02b2", @"/Views/Product/OrderTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2ae085459a130b9f395fb5d49c1cc3b0e32c6b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_OrderTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41f471d7b7847bd190e51cfe5697c311fd4d02b23660", async() => {
                WriteLiteral("\r\n    <title>产品数据表</title>\r\n    <meta charset=\"UTF-8\" />\r\n    <!-- import CSS -->\r\n    <link href=\"https://unpkg.com/element-ui/lib/theme-chalk/index.css\"\r\n          rel=\"stylesheet\" />\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41f471d7b7847bd190e51cfe5697c311fd4d02b24827", async() => {
                WriteLiteral(@"
    <el-container id=""app"">
        <el-main>
            <el-row>
                <el-col>
                    <el-table :border=""true""
                              :data=""orders""
                              style=""width: 100%"">
                        <el-table-column align=""center""
                                         header-align=""center""
                                         label=""操作"">
                            <template slot-scope=""scope"">
                                <el-button size=""mini""
                                           type=""danger""
                                           v-on:click=""onEditButtonClick(scope.row.id)"">
                                    编辑
                                </el-button>
                            </template>
                        </el-table-column>
                        <el-table-column type=""expand"">
                            <template slot-scope=""props"">
                                <el-form label-position=""");
                WriteLiteral(@"left"">
                                    <el-form-item label=""总金额："">
                                        <span>{{props.row.totalMoney}}</span>
                                    </el-form-item>
                                    <el-form-item label=""联系电话："">
                                        <span>{{props.row.userphone}}</span>
                                    </el-form-item>
                                    <el-form-item label=""配送地址："">
                                        <span>{{props.row.useraddress}}</span>
                                    </el-form-item>
                                </el-form>
                            </template>
                        </el-table-column>
                        <el-table-column :sortable=""true""
                                         header-align=""center""
                                         label=""订单编号""
                                         prop=""orderNumber"">
                        </el-table-column>
          ");
                WriteLiteral(@"              <el-table-column :sortable=""true""
                                         header-align=""center""
                                         label=""订单状态""
                                         prop=""orderState"">
                        </el-table-column>
                        <el-table-column :sortable=""true""
                                         header-align=""center""
                                         label=""菜品名称""
                                         prop=""productName"">
                        </el-table-column>
                        <el-table-column :sortable=""true""
                                         header-align=""center""
                                         label=""数量""
                                         prop=""number"">
                        </el-table-column>
                        <el-table-column :sortable=""true""
                                         header-align=""center""
                                         label=""下单时间""
            ");
                WriteLiteral(@"                             prop=""ordertime"">
                        </el-table-column>
                        <el-table-column :sortable=""true""
                                         header-align=""center""
                                         label=""收货人""
                                         prop=""userName"">
                        </el-table-column>
                    </el-table>
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
                //用于订单的信息的记录
                orders: []
            },
            methods: {
                async onEditButtonClick(id) {
 ");
                WriteLiteral(@"                   window.location.href = ""/Product/EditOrder/"" + id;
                },
                //所有订单的数据
                async GetAllOrders() {
                    // 获取所有订单数据
                    let response = await axios.get('/User/GetAllOders');
                    if (response.data.code === 'success') {
                        this.orders = response.data.data;
                    } else {
                        this.$message({
                            message: '记录获取失败',
                            type: 'error'
                        });
                    }
                },
                //用于界面的安全防止非管理员直接用URl
                async LoginAndAdmin() {

                    //用于判断用户有没有登录并且时不时管理员
                    let response = await axios.get('/User/LoginAndAdmin');
                    if (response.data.code === 'success') {

                    } else if (response.data.code === 'NoAdmin') {
                        this.$confirm('您不是管理员',
                        ");
                WriteLiteral(@"    '提示',
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
                                type: 'warning'
        ");
                WriteLiteral(@"                    })
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
                this.GetAllOrders();
                //用于防止非法用户直接用URL
                this.LoginAndAdmin();
            }
        });
    </script>
");
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
