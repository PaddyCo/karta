using System;

namespace Karta
{
    public class Map<T> where T : struct
    {
        public T[] values;
        public readonly int width;
        public readonly int height;

        public Map(int width, int height, T initialValue) {
          this.width = width;
          this.height = height;

          values = new T[width * height];
          SetAll(initialValue);
        }

        public T Get(int x, int y) {
          return values[(y * width) + x];
        }

        public T? GetSafe(int x, int y) {
          if (x >= width || x < 0 || y >= height || y < 0) {
            return null;
          }

          return values[(y * width) + x];
        }

        public void Set(int x, int y, T val) {
          values[(y * width) + x] = val;
        }

        public void SetAll(T val) {
          for (int x = 0; x < width; x++)
          {
            for (int y = 0; y < height; y++)
            {
              Set(x, y, val);
            }
          }
        }
    }
}
