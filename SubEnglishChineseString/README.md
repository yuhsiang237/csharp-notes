# SubEnglishChineseString 中英混雜字串處理

```csharp
[Fact]
public void TestSubEnglishChineseString()
{
    String str = "TESTWORD測試文字TEST";
    Assert.Equal("ESTWORD測試文字", Program.SubEnglishChineseString(str, 1, 15));
}
```
### 測試結果
<img src="/SubEnglishChineseString/Assets/test.PNG"/>
