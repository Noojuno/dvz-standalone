﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Runed.Voxel
{
    public static class Vector3IntUtil
    {
        public static Vector3Int forward = new Vector3Int(0, 0, 1);
        public static Vector3Int back = new Vector3Int(0, 0, -1);

        public static Vector3Int AdjustByDirection(this Vector3Int position, Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    return position + Vector3Int.up;
                case Direction.Down:
                    return position + Vector3Int.down;
                case Direction.Left:
                    return position + Vector3Int.left;
                case Direction.Right:
                    return position + Vector3Int.right;
                case Direction.Forward:
                    return position + Vector3IntUtil.forward;
                case Direction.Back:
                    return position + Vector3IntUtil.back;
            }

            return position;
        }

        public static Vector3Int FloorFromVector3(Vector3 vector)
        {
            int x = Mathf.FloorToInt(vector.x);
            int y = Mathf.FloorToInt(vector.y);
            int z = Mathf.FloorToInt(vector.z);

            return new Vector3Int(x, y, z);
        }

        public static Vector3Int RoundFromVector3(Vector3 vector)
        {
            int x = Mathf.RoundToInt(vector.x);
            int y = Mathf.RoundToInt(vector.y);
            int z = Mathf.RoundToInt(vector.z);

            return new Vector3Int(x, y, z);
        }
    }
}
