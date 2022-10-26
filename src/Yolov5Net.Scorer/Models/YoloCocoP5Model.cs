using System.Collections.Generic;
using Yolov5Net.Scorer.Models.Abstract;

namespace Yolov5Net.Scorer.Models
{
    public class YoloCocoP5Model : YoloModel
    {
        public override int Width { get; set; } = 640;
        public override int Height { get; set; } = 640;
        public override int Depth { get; set; } = 3;

        public override int Dimensions { get; set; } = 15;

        public override int[] Strides { get; set; } = new int[] { 8, 16, 32 };

        public override int[][][] Anchors { get; set; } = new int[][][]
        {
            new int[][] { new int[] { 010, 13 }, new int[] { 016, 030 }, new int[] { 033, 023 } },
            new int[][] { new int[] { 030, 61 }, new int[] { 062, 045 }, new int[] { 059, 119 } },
            new int[][] { new int[] { 116, 90 }, new int[] { 156, 198 }, new int[] { 373, 326 } }
        };

        public override int[] Shapes { get; set; } = new int[] { 80, 40, 20 };

        public override float Confidence { get; set; } = 0.20f;
        public override float MulConfidence { get; set; } = 0.25f;
        public override float Overlap { get; set; } = 0.45f;

        public override string[] Outputs { get; set; } = new[] { "output" };

        public override List<YoloLabel> Labels { get; set; } = new List<YoloLabel>()
        {
            new YoloLabel { Id = 1, Name = "Car1" },
            new YoloLabel { Id = 2, Name = "Car2" },
            new YoloLabel { Id = 3, Name = "Car3" },
            new YoloLabel { Id = 4, Name = "Car4" },
            new YoloLabel { Id = 5, Name = "Car5" },
            new YoloLabel { Id = 6, Name = "Car6" },
            new YoloLabel { Id = 7, Name = "Car7" },
            new YoloLabel { Id = 8, Name = "Car8" },
            new YoloLabel { Id = 9, Name = "Car9" },
            new YoloLabel { Id = 10, Name = "Car10" },
            new YoloLabel { Id = 11, Name = "Car11" },
            new YoloLabel { Id = 12, Name = "Car12" },
            new YoloLabel { Id = 13, Name = "Car13" },
            new YoloLabel { Id = 14, Name = "Car14" },
            new YoloLabel { Id = 15, Name = "Car15" },
        };

        public override bool UseDetect { get; set; } = true;

        public YoloCocoP5Model()
        {

        }
    }
}
