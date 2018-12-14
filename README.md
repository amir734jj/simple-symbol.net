# simple-symbol.net

Scala symbol in C#. This library offer persistent, thread-safe, O(1) comparison of symbols.

- Instantiate
```csharp
> Symbol.Of("Hello world!");
```

- `ToString`
```Hello world!
> 'Hello world!
```

- `GetHashCode` (uses `MD5`)
```text
> 1658389626
```
