using System;

namespace Fix_tree
{
    public class TreeFixer
    {
		private char[,] _brokenTree;
		private char _treeC;
		private char _emptySpaceC;

		private char[,] _fixedTree;
		private int _curStrIndex;
		private int _numOfTreeCInCurStr;
		private int _numOfEmptyCInCurStr;

		public TreeFixer(char[,] brokenTree, char treeC, char emptySpaceC)
        {
			_brokenTree = brokenTree;
			_treeC = treeC;
			_emptySpaceC = emptySpaceC;

			_fixedTree = new char[_brokenTree.GetLength(0), _brokenTree.GetLength(1)];
		}

		public char[,] FixTree()
		{
			for (int i = 0; i < _brokenTree.GetLength(0); i++)
            {
                _curStrIndex = i;
                CalcNumOfTreeAndEmptyCharsInCurStr();
                FixCurStr();
            }

            return _fixedTree;
        }

        private void FixCurStr()
        {
            var treeStartPos = _numOfEmptyCInCurStr / 2 + _numOfEmptyCInCurStr % 2;
            var treeEndPos = treeStartPos + _numOfTreeCInCurStr - 1;
            for (int i = 0; i < _fixedTree.GetLength(1); i++)
            {
                if (i < treeStartPos)
                {
                    _fixedTree[_curStrIndex, i] = _emptySpaceC;
                }
                else if (i <= treeEndPos)
                {
                    _fixedTree[_curStrIndex, i] = _treeC;
                }
                else
                {
                    _fixedTree[_curStrIndex, i] = _emptySpaceC;
                }
            }
        }

        private void CalcNumOfTreeAndEmptyCharsInCurStr()
        {
            _numOfTreeCInCurStr = 0;
            _numOfEmptyCInCurStr = 0;

            for (int i = 0; i < _brokenTree.GetLength(1); i++)
            {
                if (_brokenTree[_curStrIndex, i] == _treeC)
                {
                    _numOfTreeCInCurStr++;
                }
                else
                {
                    _numOfEmptyCInCurStr++;
                }
            }
        }
    }
}