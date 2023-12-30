using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_Programming
{
    public class clsTrainingExercise
    {
        private string _ExerciseName;
        private string _FEN;
        private int _MaxMoves;
        public clsTrainingExercise()
        {
            this._ExerciseName = "";
            this._FEN = "";
            this._MaxMoves = 0;
        }
        public clsTrainingExercise(string strName,string strFEN, int Moves)
        {
            this._ExerciseName = strName;
            this._FEN = strFEN ;
            this._MaxMoves = Moves;
        }

        public string ExerciseName
        {
            get { return this._ExerciseName; }
            set { this._ExerciseName = value; }
        }
        public string FEN
        {
            get { return this._FEN; }
            set { this._FEN = value; }
        }
        public int MaxMoves
        {
            get { return this._MaxMoves; }
            set { this._MaxMoves = value; }
        }

    }
}
