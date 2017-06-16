# Karta

Super basic 2D map implementation that I made its own module
because I was sick of rewriting these lines of code for every single
project, and I have a weird aversion of just pulling random
bits of code out of old abandoned projects.

I would recommend you write your own implementation but if you want to use it, go ahead!

## How to use

```csharp
using Karta;

namespace Game {
  public class World {
    // A map can be a 2D map of any struct, so a int, float, or a custom tile struct is fine
    Map<float> heightMap;

    public World() {
      // create new 256x256 map, initialize all values to 0
      heightMap = new Map<float>(256, 256, 0f);

      // Set a single value
      heightMap.Set(128, 128, 1f);

      // Get a value
      heightMap.Get(128, 128) // Returns: 1f

      // Get a value safely (does bounds checking)
      heightMap.GetSafe(128, 128) // Returns: 1f
      heightMap.GetSafe(-1, -1) // Returns: null

      // Set all tiles
      heightMap.SetAll(0f);


      // Use .width and .height to iterate map
      for (var x = 0; x < heightMap.width; x++) {
        for (var y = 0; y < heightMap.height; y++) {
          var val = heightMap.Get(x, y);
          // Code that like, renders the value or something
        }
      }
    }
  }
}
```
