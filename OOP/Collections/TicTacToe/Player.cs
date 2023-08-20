using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
  internal class Player
  {
    #region private fields
    private int _id;
    private string _name = "";
    private int _wins;
    private int _losses;
    private float _kdr;

    #endregion

    #region public fields

    #endregion

    #region public methods
    
    #endregion

    #region private methods

    #endregion

    #region constructors

    public void CreatePlayer()
    {
      _id = 0;
      _name = "Dave";
      _wins = 0;
      _losses = 0;
      _kdr = 0;
    }

    #endregion


  }
}
