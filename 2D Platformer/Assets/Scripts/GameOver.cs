using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour 
{
	public Text txScore;
	public Text txHighscore;
	Text txSelamat;
		int highscore;

	// Use this for initialization
	void Start ()
	{
		highscore = PlayerPrefs.GetInt ("HS", 0);
		if (Data.score > highscore) 
		{
			highscore = Data.score;
			PlayerPrefs.SetInt ("HS", highscore);
		} 
		else if (EnemyController.EnemyKilled == 3) 
		{
			SceneManager.LoadScene ("Congratulations");
		}
			txHighscore.text = "Highscores: " + highscore;
			txScore.text = "Scores: " + Data.score;
		}
		
		public void Replay()
		{
			Data.score = 0;
			EnemyController.EnemyKilled = 0;
			SceneManager.LoadScene("Gameplay");
		}
	}
