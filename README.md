# csharp-deconsturct-sample

本專案為 Deconstruct 解構元組的程式碼練習範例。

要撰寫解構元組方法需符合以下條件：

1. 方法名稱需為 `Deconstruct`。
2. 方法回傳值需為 `void`。
3. 每一個傳出的值需透過 `out` 來傳遞。

以下官網範例為正確的解構元組方法：

```csharp
public void Deconstruct(out string fname, out string mname, out string lname)
```

詳細請參考：https://docs.microsoft.com/zh-tw/dotnet/csharp/deconstruct#deconstructing-user-defined-types
