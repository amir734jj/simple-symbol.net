# simple-symbol.net

Scala symbol in C#. This library offers persistent, thread-safe, O(1) comparison of symbols.

- Instantiate
```csharp
> var symbol = Symbol.Of("Hello world!");
```

- `symbol.ToString()`
```Hello world!
> 'Hello world!
```

- `symbol.GetHashCode()` (uses `MD5`)
```text
> 1658389626
```

- `symbol.Value`
```text
> Hello world!
```
