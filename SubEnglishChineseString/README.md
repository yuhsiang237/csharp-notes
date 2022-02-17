# SubEnglishChineseString 中英混雜字串處理

```csharp
[Fact]
public void SubBig5StringTest()
{
    String str = "TESTWORD測試文字TEST";
    Assert.Equal("ESTWORD測試文字", Program.SubBig5String(str, 1, 15));
}
```
### 測試結果
<img src="/SubEnglishChineseString/Assets/test.PNG"/>
