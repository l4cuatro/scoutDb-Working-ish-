using Systems.Windows.Forms;

namespace ScoutCalc {

	class Team {
		int scores[10],
			rank;
		float OPR,
			DPR,
			CCWM;
	}

	class Match {
			string red1,
			red2,
			blue1,
			blue2;
		int number,
			redScore,
			blueScore;
		
		Match(int num,
			string Red1, string Red2,
			string Blue1, string Blue2) {
			number = num;
			red1 = Red1;
			red2 = Red2;
			blue1 = Blue1;
			blue2 = Blue2;
		}
		
		void upMatch(int RedScore, int BlueScore) {
			redScore = RedScore;
			blueScore = BlueScore;
		}
		
	}
	
	class Tournament {
		
		Match Matches[100] ;
		
		Team Teams[50];
		
	}
	
	class ScoutCalc {
		void main() {
			
		}
	}
}
