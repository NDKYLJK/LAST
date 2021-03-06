#pragma checksum "C:\Users\20795\Desktop\软件实训开发大作业\MVC---FinalProject\TZstore\TZstore\Views\User\EditUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8652e0385c93d68bc7ac60fde457ed0cfe35326"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_EditUser), @"mvc.1.0.view", @"/Views/User/EditUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8652e0385c93d68bc7ac60fde457ed0cfe35326", @"/Views/User/EditUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2ae085459a130b9f395fb5d49c1cc3b0e32c6b7", @"/Views/_ViewImports.cshtml")]
    public class Views_User_EditUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8652e0385c93d68bc7ac60fde457ed0cfe353263639", async() => {
                WriteLiteral("\r\n    <title>个人信息编辑页面</title>\r\n    <meta charset=\"UTF-8\" />\r\n    <!-- import CSS -->\r\n    <link href=\"https://unpkg.com/element-ui/lib/theme-chalk/index.css\" rel=\"stylesheet\" />\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8652e0385c93d68bc7ac60fde457ed0cfe353264800", async() => {
                WriteLiteral(@"
    <el-container id=""app"" style=""height: 800px; background-color: rgb(0, 183, 255);"">
        <el-main>
            <el-row>
                <el-col :span=""12"" offset=""6"">
                    <el-card class=""box-card"" style=""height: 500px;"">
                        <el-form :model=""user"" label-width=""auto"">
                            <el-form-item style=""text-align: center;"">
                                <h2>修改信息</h2>
                            </el-form-item>
                            <el-row>
                                <el-col>
                                    <el-form-item :rules=""[{ required: true, message: '请输入旧密码', trigger: 'blur' },{required: true,pattern: /^(\w){6,20}$/,message: '请输入当前的密码',trigger: 'blur'}]"" label=""旧密码"" prop=""Oldpassword"">
                                        <el-input placeholder=""请输入旧密码"" v-model=""user.Oldpassword"" show-password>
                                        </el-input>
                                    </el-form-item>
                ");
                WriteLiteral(@"                </el-col>
                            </el-row>
                            <el-row>
                                <el-col>
                                    <el-form-item :rules=""[{ required: true, message: '请输入新密码', trigger: 'blur' },{required: true,pattern: /^(\w){6,20}$/,message: '只能输入6-20个字母、数字、下划线',trigger: 'blur'}]"" label=""新密码"" prop=""userPassword"">
                                        <el-input placeholder=""请输入新密码"" v-model=""user.userPassword"" show-password>
                                        </el-input>
                                    </el-form-item>
                                </el-col>
                            </el-row>
                            <el-form-item :rules=""[{ required: true, message: '手机号', trigger: 'blur' }, { required: true, pattern: /^((13|14|15|16|17|18)[0-9]{1}\d{8})|((166|199|198)[0-9]{1}\d{7})$/, message: '请输入正确的手机号码', trigger: 'blur' }]"" label=""手机"" prop=""phoneNumber"">
                                <el-input placeholder=""手机号"" v-m");
                WriteLiteral(@"odel=""user.phoneNumber"">
                                    <template slot=""prepend"">
                                        +86
                                    </template>
                                </el-input>
                            </el-form-item>
                            <el-form-item :rules=""[{ required: true, message: '地址', trigger: 'blur' }]"" label=""地址"" prop=""address"">
                                <el-input placeholder=""地址"" v-model=""user.address"">
                                </el-input>
                            </el-form-item>
                            <el-form-item style=""text-align: center;"">
                                <el-button plain type=""danger""  round v-on:click=""onUpdataUsertButtonClick"">修改</el-button>
                                <el-button plain type=""primary"" round v-on:click=""onBackButtonClick"">返回</el-button>
                            </el-form-item>
                        </el-form>
                    </el-card>
                </e");
                WriteLiteral(@"l-col>
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
            // 用于绑定数据
            user: {
                Oldpassword: '',
                userPassword: '',
                phoneNumber:'',
                address:'',
            },
        },
        methods: {
            onBackButtonClick() {
                window.location.href = ""/User/Index"";
            },
            //修改个人信息
            async onUpdataUsertButtonClick() {
               
                let response = await axios.post('/User/UpdataUser', this.user);

                if (response.data.code === 'success') {
                    this");
                WriteLiteral(@".$message({
                        message: '修改成功',
                        type: 'success'
                    });
                    //返回登录界面
                    window.location.href = ""/User/Login"";
                } else {
                    this.$message({
                        message: '修改失败',
                        type: 'error'
                    });
                }
            },
            async GetUserBySessionName() {
                let response = await axios.get('/User/SearchUserName');
                //可以显示旧的地址和电话
                //密码因为字段名字不同不显示
                this.user = response.data.data;
                this.user.userPassword = '';
            }

        },
        mounted() {
            this.GetUserBySessionName();
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
