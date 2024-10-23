# 功能需求
### 1. 文章管理
* 發布新文章、編輯、刪除文章
* 支援 Markdown 編輯器
* 顯示文章標題、摘要；發表時間、作者
### 2. 分類與標籤管理
* 文章可加入分類與標籤
* 支援依分類或標籤篩選文章
### 3. 使用者管理
* 角色區分 : 管理員、作者、訪客
* 管理員可管理所有文章及使用者
* 作者可管理自己發表的文章
### 4. 留言功能
* 使用者可針對文章留言
* 管理員可管理或刪除不當留言
### 5. 通知與提示
* 使用 Toastr 彈跳通知顯示操作成功或錯誤
* 確認操作前使用 SweetAlert

---

# 資料庫設定(暫)
### 1. User(使用者表)
* UserId (PK)
* UserName
* Email
* PasswordHash
* Role
* CreateAt

### 2. Post(文章表)
* PostId (PK)
* Title
* Content (Markdown)
* UserId (FK -> User)
* CategoryId (FK -> Category)
* CreateAt
* UpdateAt

### 3. Category(分類表)
* CategoryId (PK)
* CategoryName

### 4. Tag(標籤表)
* TagId (PK)
* TagName

### 5. PostTag(文章 - 標籤對應表)
* PostId (FK -> Post)
* TagId (FK -> Tag)

### 6. Comment(留言表)
* CommentId (PK)
* PostId (FK -> Post)
* AuthorName
* Content
* CreateAt

## ER Model

![](./Simple%20Blog%20ER%20Model.drawio.png)

---

# 技術選擇與套件
### 1. ASP.NET Core 8.0
### 2. EF Core
### 3. SimpleMDE
### 4. Toastr.js
### 5. SweetAlert
### Bootstrap 5