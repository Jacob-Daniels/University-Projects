// Display / GUI class

class Display {
  // Attributes
  int gameMode = 0;
  int size = 50;
  int redDragonY = 0;
  int backgroundY;
  // arrays to store button position
  int[] backArray = {850, 35, 85};  // y, height, width
  int[] startArray = {400, 35, 120};
  int[] controlsArray = {525, 35, 165};
  int[] howToPlayArray = {650, 35, 190};
  int[] scoreboardArray = {775, 35, 235};
  int[] quitArray = {900, 35, 90};
  int[] restartArray = {850, 35, 130};
  int[] submitArray = {600, 30, 85};
  // text for player information
  PFont font = loadFont("Papyrus-Regular-48.vlw");  // load in font
  PFont scoreFont = loadFont("Monospaced.plain-48.vlw");
  String playGuide = "Shoot enemy dragons to gain as many points as possible!";
  String blueDragonText = "Blue Dragon:  \nPoints on kill: " + blueDragon.point + "  \nSpeed: Fast  \nRarity: Common  \nSpecial: Follows player";
  String redDragonText = "Red Dragon:  \nPoints on kill: " + redDragon.point + "  \nSpeed: Normal  \nRarity: Uncommon  \nSpecial: Shoots fireballs";
  String goldDragonText = "Gold Dragon:  \nPoints on kill: " + goldDragon.point + "  \nSpeed: Normal  \nRarity: Rare  \nSpecial: Unknown";
  String controlsTitle = "Movement:\n\n\n\nShoot:";
  String controlsText = "Left:  'a'    or    'left arrow key'\nRight:  'd'    or    'right arrow key'\n\n\n'space'    or    'mouse click'";
  String scoreTitle = "Top 10 scores:";
  String[] scoreNumbers = {"1st", "2nd", "3rd", "4th", "5th", "6th", "7th", "8th", "9th", "10th"};
  // user input variables
  String userInput = "";
  String displayError = "";
  String keyChar;
  boolean boolIncorrect = false;

  // Methods
  void update() {  // called to when game is playing
    gameplayBackground();
    renderHearts();
    renderScore();
    checkCursor();
  }

  void renderHearts() {  // display players lives on screen
    loadImage.heart.resize(50, 50);
    loadImage.grey_heart.resize(50, 50);
    if (player.playerLife == 3) {
      image(loadImage.heart, 50, 35);
      image(loadImage.heart, 100, 35);
      image(loadImage.heart, 150, 35);
    } else if (player.playerLife == 2) {
      image(loadImage.heart, 50, 35);
      image(loadImage.heart, 100, 35);
      image(loadImage.grey_heart, 150, 35);
    } else if (player.playerLife == 1) {
      image(loadImage.heart, 50, 35);
      image(loadImage.grey_heart, 100, 35);
      image(loadImage.grey_heart, 150, 35);
    }
  }

  void renderScore() {  // display score on screen
    fill(0);
    textFont(font, 30);
    text("Score: " + player.score, width - 100, 40);
  }

  void gameplayBackground() {  // display the game background
    imageMode(CORNER);
    // sliding the background image
    image(loadImage.backgroundImage, 0, backgroundY);
    image(loadImage.backgroundImage, 0, backgroundY - loadImage.backgroundImage.height);
    backgroundY += 3;
    // check if the background is off the screen
    if (backgroundY >= height) {
      backgroundY = 0;
    }
    imageMode(CENTER);
  }

  void checkCursor() {  // change cursor on mouse hover
    if (gameMode == 0) {  // start screen cursor
      if (checkButton(startArray) || checkButton(controlsArray) || checkButton(howToPlayArray) || checkButton(scoreboardArray) || checkButton(quitArray)) {  // change cursor on buttons
        cursor(HAND);
      } else {
        cursor(ARROW);
      }
    } else if (gameMode == 2  || gameMode == 3 || gameMode == 5) {  // back screen cursor
      if (checkButton(backArray)) {
        cursor(HAND);
      } else {
        cursor(ARROW);
      }
    } else if (gameMode == 4) {  // restart screen cursor
      if (checkButton(restartArray) || checkButton(submitArray)) {
        cursor(HAND);
      } else {
        cursor(ARROW);
      }
    } else {
      cursor(ARROW);
    }
  }

  void gameStartScreen() {  // create start screen
    gameplayBackground();
    animation.updateDisplayCounter();
    checkCursor();  // check cursor
    // start screen - red dragon sliding onto the screen
    animation.slidingRedDragon(width/2, redDragonY, animation.displayCounter, size);
    if (redDragonY < 220) {
      size += 1;
      redDragonY += 1;
    }
    // display text images and change the size on mouse hover
    if (checkButton(startArray)) {  // start image
      image(loadImage.start, width/2, startArray[0], 220, 60);
      animation.textGoldDragon(width/2 - 200, startArray[0] - 10, animation.displayCounter);
    } else {
      image(loadImage.start, width/2, startArray[0], 250, 70);
    }
    if (checkButton(controlsArray)) {  // controls image
      image(loadImage.controls, width/2, controlsArray[0], 290, 60);
      animation.textGoldDragon(width/2 - 230, controlsArray[0] - 10, animation.displayCounter);
    } else {
      image(loadImage.controls, width/2, controlsArray[0], 340, 70);
    }
    if (checkButton(howToPlayArray)) {  // how to play image
      image(loadImage.howToPlay, width/2, howToPlayArray[0], 370, 60);
      animation.textGoldDragon(width/2 - 270, howToPlayArray[0] - 10, animation.displayCounter);
    } else {
      image(loadImage.howToPlay, width/2, howToPlayArray[0], 400, 70);
    }
    if (checkButton(scoreboardArray)) {  // scoreboard image
      image(loadImage.scoreboard, width/2, scoreboardArray[0], 450, 60);
      animation.textGoldDragon(width/2 - 310, scoreboardArray[0] - 10, animation.displayCounter);
    } else {
      image(loadImage.scoreboard, width/2, scoreboardArray[0], 480, 70);
    }
    if (checkButton(quitArray)) {  // quit image
      image(loadImage.quit, width/2, quitArray[0], 160, 60);
      animation.textGoldDragon(width/2 - 170, quitArray[0] - 10, animation.displayCounter);
    } else {
      image(loadImage.quit, width/2, quitArray[0], 190, 70);
    }
  }

  void controlsScreen() {  // create controls screen
    pageUpdate();
    // controls image
    image(loadImage.controls, width/2, 100);
    // display text
    textFont(font, 40);
    text(controlsTitle, width/2, 230);
    text(controlsText, width/2, 300);
    // line to underline titles
    line(width/2 - 100, 240, width/2 + 100, 240);
    line(width/2 - 70, 500, width/2 + 70, 500);
  }

  void howToPlayScreen() {  // create how to play screen
    pageUpdate();
    // how to play image
    image(loadImage.howToPlay, width/2, 100);
    // display dragon images
    animation.blueDragonAnimation(width/2 - width/3, 400, animation.displayCounter);
    animation.redDragonAnimation(width/2, 400, animation.displayCounter);
    animation.goldDragonAnimation(width/2 + width/3, 400, animation.displayCounter);
    // display text
    textFont(font, 30);
    text(playGuide, width/2, 250);
    text(blueDragonText, width/2 - width/3, 700, 400, 400);
    text(redDragonText, width/2, 700, 400, 400);
    text(goldDragonText, width/2 + width/3, 700, 400, 400);
  }

  void scoreboard() {  // create scoreboard screen
    pageUpdate();
    // scoreboard image
    image(loadImage.scoreboard, width/2, 100);
    // get top scores
    if (gameScoreboard.loopScore == 0) {  // only loop once
      gameScoreboard.checkHighScore();
      gameScoreboard.loopScore = 1;
    }
    // display scores on page
    textFont(font, 50);
    text(scoreTitle, width/2, 220);
    line(width/2 - 165, 230, width/2 + 165, 230);
    textAlign(LEFT);
    textFont(scoreFont, 30);
    int scoreX = width/2 - 300;
    int scoreY = 300;
    for (int i=0; i < gameScoreboard.topScores.length; i++) {  // iterate through topScores[] array
      if (i == 5) {
        scoreX = width/2 + 175;
        scoreY = 300;
      }
      text(scoreNumbers[i], scoreX - 110, scoreY);
      text(gameScoreboard.topScores[i], scoreX, scoreY);
      scoreY += 100;
    }
    textAlign(CENTER);
  }

  void renderBackButton() {  // display and update animations for the back button
    // back button
    if (checkButton(backArray)) {  // back image
      image(loadImage.back, width/2, 850, 150, 45);
    } else {
      image(loadImage.back, width/2, 850, 180, 55);
    }
    if (checkButton(backArray)) {  // back button dragon animation
      animation.textGoldDragon(width/2 - 160, backArray[0] - 10, animation.displayCounter);
    }
  }

  void pageUpdate() {  // call to methods when page is changed
    gameplayBackground();
    animation.updateDisplayCounter();
    checkCursor();
    renderBackButton();
    startScreenDragon();
  }

  void gameOverScreen() {  // create game over screen
    gameplayBackground();
    // update cursor
    checkCursor();
    // display game over image
    image(loadImage.gameoverImage, width/2, 100);
    // change size of restart image on mouse hover
    if (checkButton(restartArray)) {  // restart button
      image(loadImage.restart, width/2, restartArray[0], 250, 60);
    } else {
      image(loadImage.restart, width/2, restartArray[0], 280, 70);
    }
    // display score on screen
    textFont(font, 50);
    text("Score: " + player.score, width/2, 300);
    // textbox for player name
    textSize(40);
    text("Enter your name:", width/2, 400);
    textFont(scoreFont, 30);
    fill(255);
    rect(width/2, 470, 210, 40);
    fill(0);
    text(userInput, width/2, 480);  // display user input
    if (checkButton(submitArray)) {  // resize submit button on mouse hover
      image(loadImage.submitImage, width/2, submitArray[0], 150, 45);
    } else {
      image(loadImage.submitImage, width/2, submitArray[0], 180, 55);
    }
  }

  void gameRestart() {  // reset values for a new game
    // user input
    userInput = "";
    boolIncorrect = false;
    // player position
    player.x = width/2;
    // player life
    player.playerLife = 3;
    // score
    player.score = 0;
    // remove enemy projectiles (fireballs)
    int listElement = 0;
    while (listElement < fireballList.size()) {
      fireballList.remove(fireballList.get(listElement));
    }
    // remove enemies
    while (listElement < blueDragonList.size()) {  // blue dragons
      blueDragonList.remove(listElement);
    }
    while (listElement < redDragonList.size()) {  // red dragons
      redDragonList.remove(listElement);
    }
    while (listElement < goldDragonList.size()) {  // gold dragons
      goldDragonList.remove(listElement);
    }
    // player projectiles
    while (listElement < projectileList.size()) {
      projectileList.remove(projectileList.get(listElement));
    }
    // remove death animation
    while (listElement < deathList.size()) {
      deathList.remove(deathList.get(listElement));
    }
    // create new enemy objects
    newDragonObjects();
    // reset start screen dragon
    startScreenDragon();
  }

  void newDragonObjects() {
    // new enemy objects
    for (int i=1; i <= 12; i++) {
      enemy.dragonType = int(random(0, 30));
      // create object depending on dragon type
      if (enemy.dragonType >= 0 && enemy.dragonType < enemy.redMinType) {  // blue dragon
        blueDragon = new DragonBlue(int(random(120, 1080)), int(random(1100, 1500)), 150, 5, int(random(0, 40)));
        blueDragonList.add(blueDragon);
      } else if (enemy.dragonType >= enemy.redMinType && enemy.dragonType < enemy.goldMinType) {  // red dragon
        redDragon = new DragonRed(int(random(120, 1080)), int(random(1100, 1500)), 150, 4, int(random(0, 40)), int(random(1, 300)));
        redDragonList.add(redDragon);
      } else if (enemy.dragonType >= enemy.goldMinType && enemy.dragonType < 30) {  // gold dragon
        goldDragon = new DragonGold(int(random(120, 1080)), int(random(1100, 1500)), 150, 4, int(random(0, 40)));
        goldDragonList.add(goldDragon);
      }
    }
  }

  void startScreenDragon() {
    // dragon start screen stats
    redDragonY = 0;
    size = 0;
  }

  boolean checkButton(int[] array) {  // check mouse is on button
    if (abs(mouseY - array[0]) < array[1] && abs(mouseX - width/2) < array[2]) {
      return true;
    } else {
      return false;
    }
  }
}  // end of 'Display' class
