# 	C#

[TOC]



### 创建一个win应用



![image-20210904110559862](C:%5CUsers%5CLitterhui%5CAppData%5CRoaming%5CTypora%5Ctypora-user-images%5Cimage-20210904110559862.png)



这个form.cs是win的主体，可以（查看源代码）手动写代码，也可以单击拉控件。

```c#
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "这是我的第一个Win程序";
            Label lblShow = new Label();
            lblShow.Location = new Point(50, 30);
            lblShow.AutoSize = true;
            lblShow.Text = "本程序由Litter hui设计";
            this.Controls.Add(lblShow);
        }
```

### 控件设置

![image-20210904113249154](C:%5CUsers%5CLitterhui%5CAppData%5CRoaming%5CTypora%5Ctypora-user-images%5Cimage-20210904113249154.png)

```c#
        private void btnOK_Click(object sender, EventArgs e)    //按键事件
        {
            string strResult;
            strResult = textBox1.Text + ",你好！欢迎使用本程序！";
            labelshow.Text = strResult;
        }
```

不同的控件有不同的属性，属性里面的每个信息，都可以在.cs文件中调用，但是前后的信息要一样，调用时要像类一样去使用。

### WEB组件

```c#
public partial class text : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "实例1-4";
        Label lblShow = new Label();
        lblShow.Text = "这是我的第一个Web版的C#程序。<br/>";
        lblShow.Text +="请记住，C#的<b>最大特色</b>是它统一了各种应用程序的开发模式。<br/>";
        lblShow.Text += "若需帮助，请与作者<a href='1973999197@qq.com'>胡明辉</a>联系。";
        lblShow.Font.Size = FontUnit.Point(16);
        this.Controls.Add(lblShow);
    }
}
```

​	HTML标记

```
<br>	换行
<b>		加粗文字
<a>		显示超链接
```

### 变量

![image-20210904154639684](C:%5CUsers%5CLitterhui%5CAppData%5CRoaming%5CTypora%5Ctypora-user-images%5Cimage-20210904154639684.png)

变量的使用个C语言差别不大，按照C语言的格式去写就行。

### 结构体

结构体的使用和C语言一样，只不过它内置有一些特定的结构体

![image-20210904155211469](C:%5CUsers%5CLitterhui%5CAppData%5CRoaming%5CTypora%5Ctypora-user-images%5Cimage-20210904155211469.png)

```c#
        struct Student
        {
            public int id;
            public string name;
            public int age;
            public char sex;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Student a;
            a.id = 0001;
            a.name = "小辉";
            a.age = 20;
            a.sex = '男';
            labelshow.Text = "student information\nname:" + a.name;
            labelshow.Text += "\nID:" + a.id;
            labelshow.Text += "\nSex:" + a.sex;
            labelshow.Text += "\nage:" + a.age;

        }
```

### 变量转化

![image-20210904160737552](C:%5CUsers%5CLitterhui%5CAppData%5CRoaming%5CTypora%5Ctypora-user-images%5Cimage-20210904160737552.png)

