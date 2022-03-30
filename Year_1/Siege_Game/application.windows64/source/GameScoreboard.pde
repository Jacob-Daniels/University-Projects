// save score to scoreboard file

class GameScoreboard {
  // attibutes
  String playerName = "Player";
  int playerScore = 10;
  String[] topScores = {"", "", "", "", "", "", "", "", "", ""};
  int[] scoreIntegers = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
  String checkString;
  String stringNum;
  int loopScore = 0;
  // file attributes
  String fileName = "scoreboard.txt";
  File scoreboardFile;
  Scanner scanFile;

  // methods
  void createFile() {  // create new file (if file is not there)
    scoreboardFile = new File(dataPath(fileName));  // create file in game directory
  }

  void appendFile() {  // write to file
    try {
      // write to file
      PrintWriter wFile = new PrintWriter(new BufferedWriter(new FileWriter(scoreboardFile, true)));
      wFile.println(display.userInput + "  -  " + player.score);
      // close file
      wFile.close();
    } 
    catch (IOException error) {
      println("Error when writing to file:" + error);
    }
  }

  void checkHighScore() {  // check the highest score within the txt file
    // reset arrays
    Arrays.fill(topScores, "Empty");
    Arrays.fill(scoreIntegers, 0);
    try {
      // read file
      scanFile = new Scanner(scoreboardFile);
      // check top 10 high scores
      while (scanFile.hasNextLine()) {
        stringNum = "";
        checkString = scanFile.nextLine();
        for (int i=0; i < checkString.length(); i++) {
          //println(checkString.checkString.matches(".*\\d.*"));
          if (Character.isDigit(checkString.charAt(i))) {
            stringNum += checkString.charAt(i);  // get digits within string
          }
        }
        for (int i=0; i < scoreIntegers.length; i++) {
          if (Integer.parseInt(stringNum) > scoreIntegers[i]) {  // check if score should be replaced
            //newIntegers = scoreIntegers;
            for (int j = scoreIntegers.length-1; j > i; j--) {  // loop backwards to replace values
              scoreIntegers[j] = scoreIntegers[j-1];
              topScores[j] = topScores[j-1];
            }

            scoreIntegers[i] = Integer.parseInt(stringNum);
            topScores[i] = checkString;
            break;  // break for loop
          }
        }
      }
    }
    catch (Exception error) {
      println("Error when reading file: " + error);
    }
  }
}  // end of class
