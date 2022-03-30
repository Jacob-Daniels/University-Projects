import processing.core.*; 
import processing.data.*; 
import processing.event.*; 
import processing.opengl.*; 

import java.io.*; 
import java.util.*; 

import java.util.HashMap; 
import java.util.ArrayList; 
import java.io.File; 
import java.io.BufferedReader; 
import java.io.PrintWriter; 
import java.io.InputStream; 
import java.io.OutputStream; 
import java.io.IOException; 

public class Siege_Game extends PApplet {


// importing library
  // file class
  // scanner class
// referencing object to the class
Player player;
Enemy enemy;
DragonBlue blueDragon;
DragonRed redDragon;
DragonGold goldDragon;
Projectile projectile;
EnemyProjectile enemyProjectile;
Display display;
Animation animation;
DeathAnimation deathAnimation;
LoadImages loadImage;
GameScoreboard gameScoreboard;
// array list to store enemies
ArrayList<Projectile> projectileList = new ArrayList<Projectile>();
ArrayList<EnemyProjectile> fireballList = new ArrayList<EnemyProjectile>();
ArrayList<DragonBlue> blueDragonList = new ArrayList<DragonBlue>();
ArrayList<DragonRed> redDragonList = new ArrayList<DragonRed>();
ArrayList<DragonGold> goldDragonList = new ArrayList<DragonGold>();
ArrayList<DeathAnimation> deathList = new ArrayList<DeathAnimation>();

public void setup() {
  
  surface.setTitle("Siege Game");
  rectMode(CENTER);
  imageMode(CENTER);
  textAlign(CENTER);
  textSize(20);
  fill(0);
  // create objects
  createObjects();
  // create score txt file
  gameScoreboard = new GameScoreboard();
  gameScoreboard.createFile();
}

public void draw() {
  // check if game has started
  if (display.gameMode == 1) {  // play the game
    // call to update all objects
    updateObjects();
  } else if (display.gameMode == 0) {  // start screen
    display.gameStartScreen();
  } else if (display.gameMode == 2) {  // controls screen
    display.controlsScreen();
  } else if (display.gameMode == 3) {  // how to play screen
    display.howToPlayScreen();
  } else if (display.gameMode == 4) {  // restart screen
    display.gameOverScreen();
  } else if (display.gameMode == 5) {
    display.scoreboard();
  }
}

// check for key press
public void keyPressed() {
  if (display.gameMode == 1) {  // if user is playing the game
    if (key == CODED) {
      if (keyCode == LEFT) {
        player.moveLeft = true;
      }
      if (keyCode == RIGHT) {
        player.moveRight = true;
      }
    }
    if (key == 32) { // ascii decimal for 'SPACE'
      // setting max projectiles within the ArrayList
      if (player.reloadTimer == 0) {
        player.reloadTimer = 30;
        if (projectileList.size() < 2) {
          projectile = new Projectile(player.x - 30, player.y, 60, 7, PApplet.parseInt(random(6)), PApplet.parseInt(random(1, 3)));
          projectileList.add(projectile);
        }
      }
    } else if (key == 97) {  // 'a' key
      player.moveLeft = true;
    } else if (key == 100) {  // 'd' key
      player.moveRight = true;
    }
  }
  if (display.gameMode == 4) {  // if game has ended
    if (key == 8) {  // if backspace is pressed remove character from string
      if (display.userInput.length() > 0) {
        display.userInput = display.userInput.substring(0, display.userInput.length()-1);  // remove the end of the string
      }
    } else {  // add key to string if it is 'a-z/A-Z'
      display.keyChar = String.valueOf(key);
      if (display.keyChar.matches("[a-zA-Z]+")) {
        if (display.userInput.length() < 10) {
          display.userInput += key;
        }
      }
    }
  }
}
public void keyReleased() {
  if (key == CODED) {
    if (keyCode == LEFT) {
      player.moveLeft = false;
    }
    if (keyCode == RIGHT) {
      player.moveRight = false;
    }
  }
  if (key == 97) {  // 'a' key
    player.moveLeft = false;
  }
  if (key == 100) {  // 'd' key
    player.moveRight = false;
  }
}

public void mousePressed() {
  if (display.gameMode == 0) {
    if (display.checkButton(display.startArray)) {  // is start button pressed
      display.gameMode = 1;
    } else if (display.checkButton(display.controlsArray)) {  // is controls button pressed
      display.gameMode = 2;
    } else if (display.checkButton(display.howToPlayArray)) {  // is how to play button pressed
      display.gameMode = 3;
    } else if (display.checkButton(display.scoreboardArray)) {
      display.gameMode = 5;
    } else if (display.checkButton(display.quitArray)) {  // is quit button pressed
      exit();
    }
  } else if (display.gameMode == 1) {  // allow mouse to shoot when game is playing
    if (player.reloadTimer == 0) {
      player.reloadTimer = 30;
      if (projectileList.size() < 5) {
        projectile = new Projectile(player.x - 30, player.y, 60, 7, PApplet.parseInt(random(6)), PApplet.parseInt(random(1, 3)));
        projectileList.add(projectile);
      }
    }
  } else if (display.gameMode == 2 || display.gameMode == 3) {  // new page when back button is pressed
    if (display.checkButton(display.backArray)) {  // is back button pressed
      display.gameMode = 0;  // display start screen
    }
  } else if (display.gameMode == 5) {  // new page when back button is pressed
    if (display.checkButton(display.backArray)) {  // is back button pressed
      gameScoreboard.loopScore = 0;  // reset loop
      display.gameMode = 0;  // display start screen
    }
  } else if (display.gameMode == 4) {  // restart page 
    if (display.checkButton(display.submitArray)) {  // submit button
      if (display.boolIncorrect == false) {  // check if string the correct length
        // submit score and restart game
        gameScoreboard.appendFile();
        display.gameRestart();
        display.gameMode = 0;
      }
    } else if (display.checkButton(display.restartArray)) {  // restart game if clicked
      // reset stats for a new game to begin
      display.gameRestart();
      display.gameMode = 0;
    }
  }
}

public void createObjects() {  // creating objects for each class
  loadImage = new LoadImages();
  animation = new Animation();
  // player
  player = new Player(width/2, 175, 30, 5);
  // create enemies
  enemy = new Enemy(0, 0, 0, 0);
  blueDragon = new DragonBlue(0, 0, 0, 0, 0);
  redDragon = new DragonRed(0, 0, 0, 0, 0, 0);  // null objects to call to during startup
  goldDragon = new DragonGold(0, 0, 0, 0, 0);
  // Display object
  display = new Display();
  // add new objects to dragon lists
  display.newDragonObjects();
  // enemy projectile
  enemyProjectile = new EnemyProjectile(0, 0, 0, 0, false);
}

// updating objects
public void updateObjects() {
  // update Display/Hud
  display.update();
  // update player
  player.update();
  // update death animation
  if (deathList.size() > 0) {
    for (int i=0; i < deathList.size(); i++) {  //  render each object within the list
      deathAnimation.render(i);
    }
  }
  // updating each enemy (object) within the array list
  for (int i=0; i < blueDragonList.size(); i++) {  // blue
    blueDragonList.get(i).update();
  }
  for (int i=0; i < redDragonList.size(); i++) {  // red
    redDragonList.get(i).update();
  }
  for (int i=0; i < goldDragonList.size(); i++) {  // gold
    goldDragonList.get(i).update();
  }
  // updating each projectile on screen
  if (projectileList.size() > 0) {
    for (int i = 0; i < projectileList.size(); i++) {
      projectileList.get(i).update();
    }
  }
  // enemy fireball/projectile
  for (int fireball=0; fireball < fireballList.size(); fireball++) {
    fireballList.get(fireball).update();
  }
  // check if enemy projectile should be removed
  for (int i = 0; i < fireballList.size(); i++) {
    if (fireballList.get(i).removeProjectile == true) {
      fireballList.remove(i);
    }
  }
}
// class to render animations

class Animation {
  // attrubites
  int displayCounter;
  int fireballCounter;
  int playerCounter;

  // Methods
  public void updatePlayerCounter() {  // update player counter
    if (playerCounter < 80) {
      playerCounter++;
    } else {
      playerCounter = 0;
    }
  }

  public void updateFireballCounter() {  // update fireball counter
    if (fireballCounter < 40) {
      fireballCounter++;
    } else {
      fireballCounter = 0;
    }
  }

  public void updateDisplayCounter() {  // update display counter
    if (displayCounter < 40) {
      displayCounter++;
    } else {
      displayCounter = 0;
    }
  }

  // render/animate images
  public void playerAnimation(int x, int y) {
    // player mage animation
    if (playerCounter <= 40) {
      image(loadImage.player_witch_1, x, y);
    } else if (playerCounter <= 80) {
      image(loadImage.player_witch_2, x, y);
    }
    // player cloud animation
    if (playerCounter <= 10) {
      image(loadImage.player_cloud_1, x - 20, y + 20, 200, 200);
    } else if (playerCounter <= 20) {
      image(loadImage.player_cloud_1, x - 19, y + 19, 190, 200);
    } else if (playerCounter <= 30) {
      image(loadImage.player_cloud_1, x - 18, y + 18, 180, 200);
    } else if (playerCounter <= 40) {
      image(loadImage.player_cloud_1, x - 17, y + 17, 170, 200);
    } else if (playerCounter <= 50) {
      image(loadImage.player_cloud_1, x - 16, y + 16, 160, 200);
    } else if (playerCounter <= 60) {
      image(loadImage.player_cloud_1, x - 17, y + 17, 170, 200);
    } else if (playerCounter <= 70) {
      image(loadImage.player_cloud_1, x - 18, y + 18, 180, 200);
    } else if (playerCounter <= 80) {
      image(loadImage.player_cloud_1, x - 19, y + 19, 190, 200);
    }
  }
  // fireballs
  public void fireballAnimation(int x, int y, int size) {
    if (animation.fireballCounter <= 10) {
      image(loadImage.fireballs[0], x, y, size, size);
    } else if (animation.fireballCounter <= 20) {
      image(loadImage.fireballs[1], x, y, size, size);
    } else if (animation.fireballCounter <= 30) {
      image(loadImage.fireballs[2], x, y, size, size);
    } else if (animation.fireballCounter <= 40) {
      image(loadImage.fireballs[3], x, y, size, size);
    }
  }
  // Dragons
  public void blueDragonAnimation(int x, int y, int dragonCounter) {  // animation for the blue dragon
    if (dragonCounter <= 10) {
      image(loadImage.blue_dragon[0], x, y);
    } else if (dragonCounter <= 20) {
      image(loadImage.blue_dragon[1], x, y);
    } else if (dragonCounter <= 30) {
      image(loadImage.blue_dragon[2], x, y);
    } else if (dragonCounter <= 40) {
      image(loadImage.blue_dragon[1], x, y);
    }
  }

  public void redDragonAnimation(int x, int y, int dragonCounter) {  // animation for the red dragon
    if (dragonCounter <= 10) {
      image(loadImage.red_dragon[0], x, y);
    } else if (dragonCounter <= 20) {
      image(loadImage.red_dragon[1], x, y);
    } else if (dragonCounter <= 30) {
      image(loadImage.red_dragon[2], x, y);
    } else if (dragonCounter <= 40) {
      image(loadImage.red_dragon[1], x, y);
    }
  }

  public void goldDragonAnimation(int x, int y, int dragonCounter) {  // animation for the gold dragon
    if (dragonCounter <= 10) {
      image(loadImage.gold_dragon[0], x, y);
    } else if (dragonCounter <= 20) {
      image(loadImage.gold_dragon[1], x, y);
    } else if (dragonCounter <= 30) {
      image(loadImage.gold_dragon[2], x, y);
    } else if (dragonCounter <= 40) {
      image(loadImage.gold_dragon[1], x, y);
    }
  }
  // start screen dragons
  public void textGoldDragon(int x, int y, int dragonCounter) {  // animation for the gold dragon on mouse hover
    if (dragonCounter <= 10) {
      image(loadImage.gold_dragon_mouse[0], x, y);
    } else if (dragonCounter <= 20) {
      image(loadImage.gold_dragon_mouse[1], x, y);
    } else if (dragonCounter <= 30) {
      image(loadImage.gold_dragon_mouse[2], x, y);
    } else if (dragonCounter <= 40) {
      image(loadImage.gold_dragon_mouse[1], x, y);
    }
  }

  public void slidingRedDragon(int x, int y, int dragonCounter, int size) {  // animation for the sliding the dragon on start screen
    if (dragonCounter <= 10) {
      image(loadImage.red_dragon_front[0], x, y, size, size);
    } else if (dragonCounter <= 20) {
      image(loadImage.red_dragon_front[1], x, y, size, size);
    } else if (dragonCounter <= 30) {
      image(loadImage.red_dragon_front[2], x, y, size, size);
    } else if (dragonCounter <= 40) {
      image(loadImage.red_dragon_front[1], x, y, size, size);
    }
  }
}  // end of 'Animation' class
// animation on enemy death

class DeathAnimation {
  // attributes
  int x;
  int y;
  int deathCounter;

  // constructor
  DeathAnimation(int x, int y, int deathCounter) {
    this.x = x;
    this.y = y;
    this.deathCounter = deathCounter;
  }
  // methods
  public void render(int k) {
    // reduce counter
    deathList.get(k).deathCounter--;
    // display image
    if (deathList.get(k).deathCounter < 5) {
      image(loadImage.deathImage[22], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 10) {
      image(loadImage.deathImage[21], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 15) {
      image(loadImage.deathImage[20], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 20) {
      image(loadImage.deathImage[19], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 25) {
      image(loadImage.deathImage[18], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 30) {
      image(loadImage.deathImage[17], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 35) {
      image(loadImage.deathImage[16], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 40) {
      image(loadImage.deathImage[15], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 45) {
      image(loadImage.deathImage[14], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 50) {
      image(loadImage.deathImage[13], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 55) {
      image(loadImage.deathImage[12], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 60) {
      image(loadImage.deathImage[11], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 65) {
      image(loadImage.deathImage[10], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 70) {
      image(loadImage.deathImage[9], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 75) {
      image(loadImage.deathImage[8], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 80) {
      image(loadImage.deathImage[7], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 85) {
      image(loadImage.deathImage[6], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 90) {
      image(loadImage.deathImage[5], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 95) {
      image(loadImage.deathImage[4], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 100) {
      image(loadImage.deathImage[3], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 105) {
      image(loadImage.deathImage[2], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 110) {
      image(loadImage.deathImage[1], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 115) {
      image(loadImage.deathImage[0], deathList.get(k).x, deathList.get(k).y);
    }
    if (deathList.get(k).deathCounter == 0) {
      deathList.remove(deathList.get(k));
    }
  }
}  // end of class
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
  public void update() {  // called to when game is playing
    gameplayBackground();
    renderHearts();
    renderScore();
    checkCursor();
  }

  public void renderHearts() {  // display players lives on screen
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

  public void renderScore() {  // display score on screen
    fill(0);
    textFont(font, 30);
    text("Score: " + player.score, width - 100, 40);
  }

  public void gameplayBackground() {  // display the game background
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

  public void checkCursor() {  // change cursor on mouse hover
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

  public void gameStartScreen() {  // create start screen
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

  public void controlsScreen() {  // create controls screen
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

  public void howToPlayScreen() {  // create how to play screen
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

  public void scoreboard() {  // create scoreboard screen
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

  public void renderBackButton() {  // display and update animations for the back button
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

  public void pageUpdate() {  // call to methods when page is changed
    gameplayBackground();
    animation.updateDisplayCounter();
    checkCursor();
    renderBackButton();
    startScreenDragon();
  }

  public void gameOverScreen() {  // create game over screen
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

  public void gameRestart() {  // reset values for a new game
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

  public void newDragonObjects() {
    // new enemy objects
    for (int i=1; i <= 12; i++) {
      enemy.dragonType = PApplet.parseInt(random(0, 30));
      // create object depending on dragon type
      if (enemy.dragonType >= 0 && enemy.dragonType < enemy.redMinType) {  // blue dragon
        blueDragon = new DragonBlue(PApplet.parseInt(random(120, 1080)), PApplet.parseInt(random(1100, 1500)), 150, 5, PApplet.parseInt(random(0, 40)));
        blueDragonList.add(blueDragon);
      } else if (enemy.dragonType >= enemy.redMinType && enemy.dragonType < enemy.goldMinType) {  // red dragon
        redDragon = new DragonRed(PApplet.parseInt(random(120, 1080)), PApplet.parseInt(random(1100, 1500)), 150, 4, PApplet.parseInt(random(0, 40)), PApplet.parseInt(random(1, 300)));
        redDragonList.add(redDragon);
      } else if (enemy.dragonType >= enemy.goldMinType && enemy.dragonType < 30) {  // gold dragon
        goldDragon = new DragonGold(PApplet.parseInt(random(120, 1080)), PApplet.parseInt(random(1100, 1500)), 150, 4, PApplet.parseInt(random(0, 40)));
        goldDragonList.add(goldDragon);
      }
    }
  }

  public void startScreenDragon() {
    // dragon start screen stats
    redDragonY = 0;
    size = 0;
  }

  public boolean checkButton(int[] array) {  // check mouse is on button
    if (abs(mouseY - array[0]) < array[1] && abs(mouseX - width/2) < array[2]) {
      return true;
    } else {
      return false;
    }
  }
}  // end of 'Display' class
// blue dragon class

public class DragonBlue extends Enemy {
  // attributes
  final int point = 1;
  final int damage = 1;
  float animationCounter;
  float xDistance = 1;
  float rotate = 0.06f;

  // constructor
  DragonBlue(int x, int y, int size, int speed, int animationCounter) {
    super(x, y, size, speed);
    this.animationCounter = animationCounter;
  }
  // methods
  public void render() {
    // update animation counter
    dragonCounter();
    // move dragon towards the player
    trackPlayer();
  }

  public void trackPlayer() {  // moves the enemy towards the player on x axis
    if (this.y >= 500) {  // move enemy within a set range
      if (this.x - player.x > 0 && this.x - player.x < 300) {
        rotateDragon(-rotate);
        this.x -= xDistance;
      } else if (this.x - player.x < 0 && this.x - player.x > -300) {
        rotateDragon(rotate);
        this.x += xDistance;
      } else {
        straightDragon();
      }
    } else if (this.y < 500 && this.y > 250) {  // when enemy is closer to the player it moves faster
      if (this.x - player.x > 0 && this.x - player.x < 300) {
        rotateDragon(-rotate);
        this.x -= xDistance * 2;
      } else if (this.x - player.x < 0 && this.x - player.x > -300) {
        rotateDragon(rotate);
        this.x += xDistance * 2;
      } else {
        straightDragon();
      }
    } else {
      straightDragon();
    }
  }

  public void straightDragon() {  // display straight image
    animation.blueDragonAnimation(x, y, (int)animationCounter);
  }

  public void rotateDragon(float rotation) {  // display rotated dragon
    pushMatrix();
    translate(x, y);
    rotate(rotation);
    translate(0, 0);
    animation.blueDragonAnimation(0, 0, (int)animationCounter);
    popMatrix();
  }

  public void dragonCounter() {
    // check values to increase or reset
    if (animationCounter < 40) {
      animationCounter += 1.5f;
    } else {
      animationCounter = 0;
    }
  }

  public void collision() {  // collision between other dragons
    for (DragonBlue dragons : blueDragonList) {
      if (checkOtherDragons(dragons) == true) {
        if (dragons.y > 1050) {  // reposition enemies if off screen
          dragons.y = PApplet.parseInt(random(1100, 1800));
          dragons.x = PApplet.parseInt(random(xLeftBorder, xRightBorder));
        }
      }
    }
  }

  public boolean checkOtherDragons(DragonBlue other) {  // checks collision between other dragons
    for (DragonRed dragons : redDragonList) {
      if (other.boolCollisionEnemy(dragons) == true) {
        return true;
      }
    }
    for (DragonGold dragons : goldDragonList) {
      if (other.boolCollisionEnemy(dragons) == true) {
        return true;
      }
    }
    return false;
  }
}  // end of class
// gold dragon class

class DragonGold extends Enemy {
  // attributes
  final int point = 5;
  final int damage = 1;
  int animationCounter;

  // constructor 
  DragonGold(int x, int y, int size, int speed, int animationCounter) {
    super(x, y, size, speed);
    this.animationCounter = animationCounter;
  }
  // methods
  public void render() {
    // update animation counter
    dragonCounter();
    // display enemy image
    animation.goldDragonAnimation(x, y, animationCounter);
  }

  public void dragonCounter() {
    // check values to increase or reset
    if (animationCounter < 40) {
      animationCounter++;
    } else {
      animationCounter = 0;
    }
  }

  public void collision() {  // collision between other dragons
    for (DragonGold dragons : goldDragonList) {
      if (checkOtherDragons(dragons) == true) {
        if (dragons.y > 1050) {  // reposition enemies if off screen
          dragons.y = PApplet.parseInt(random(1100, 1800));
          dragons.x = PApplet.parseInt(random(xLeftBorder, xRightBorder));
        }
      }
    }
  }

  public boolean checkOtherDragons(DragonGold other) {  // checks collision between other dragons
    for (DragonRed dragons : redDragonList) {
      if (other.boolCollisionEnemy(dragons) == true) {
        return true;
      }
    }
    for (DragonBlue dragons : blueDragonList) {
      if (other.boolCollisionEnemy(dragons) == true) {
        return true;
      }
    }
    return false;
  }
}  // end of class
// red dragon class

class DragonRed extends Enemy {
  // attributes
  final int point = 2;
  final int damage = 1;
  int fireballCooldown;
  int animationCounter;

  // constructor
  DragonRed(int x, int y, int size, int speed, int animationCounter, int fireballCooldown) {
    super(x, y, size, speed);
    this.animationCounter = animationCounter;
    this.fireballCooldown = fireballCooldown;
  }

  // methods
  public void render() {
    // update animcation counter
    dragonCounter();
    // display enemy image
    animation.redDragonAnimation(x, y, animationCounter);
    // update fireball projectile
    enemyProjectile.checkFireball();
  }

  public void dragonCounter() {
    // check values to increase or reset
    if (animationCounter < 40) {
      animationCounter++;
    } else {
      animationCounter = 0;
    }
  }
  public void collision() {  // collision between other dragons
    for (DragonRed dragons : redDragonList) {
      if (checkOtherDragons(dragons) == true) {
        if (dragons.y > 1050) {  // reposition enemies if off screen
          dragons.y = PApplet.parseInt(random(1100, 1800));
          dragons.x = PApplet.parseInt(random(xLeftBorder, xRightBorder));
        }
      }
    }
  }

  public boolean checkOtherDragons(DragonRed other) {  // checks collision between other dragons
    for (DragonGold dragons : goldDragonList) {
      if (other.boolCollisionEnemy(dragons) == true) {
        return true;
      }
    }
    for (DragonBlue dragons : blueDragonList) {
      if (other.boolCollisionEnemy(dragons) == true) {
        return true;
      }
    }
    return false;
  }
}  // end of class
// Enemy class

class Enemy extends Entity {
  // Attributes
  final int xLeftBorder = 75;
  final int xRightBorder = 1125;  // 1080
  final int redMinType = 18;
  final int goldMinType = 28;
  int dragonType;

  // Constructor
  Enemy(int x, int y, int size, int speed) {
    super(x, y, size, speed);
  }

  // Methods
  public void render() {
    // children of 'Enemy' class render own images
  }

  public void move() {
    // check enemy is on screen to move
    if (this.y > -size/2) {
      this.y -= speed;
    } else {
      if (this instanceof DragonBlue) {
        // delete current enemy
        blueDragonList.remove(this);
        // create a new random enemy
        enemy.createEnemy();
      } else if (this instanceof DragonRed) {
        // delete current enemy
        redDragonList.remove(this);
        // create a new random enemy
        enemy.createEnemy();
      } else if (this instanceof DragonGold) {
        // delete current enemy
        goldDragonList.remove(this);
        // create a new random enemy
        enemy.createEnemy();
      }
    }
  }

  public void createEnemy() {  // declare new enemy
    // create enemies for child classes
    dragonType = PApplet.parseInt(random(0, 30));
    // create object depending on dragon type
    if (dragonType >= 0 && dragonType < redMinType) {  // blue dragon
      blueDragon = new DragonBlue(PApplet.parseInt(random(120, 1080)), PApplet.parseInt(random(1100, 1500)), 150, 5, PApplet.parseInt(random(0, 40)));
      blueDragonList.add(blueDragon);
    } else if (dragonType >= redMinType && dragonType < goldMinType) {  // red dragon
      redDragon = new DragonRed(PApplet.parseInt(random(120, 1080)), PApplet.parseInt(random(1100, 1500)), 150, 4, PApplet.parseInt(random(0, 40)), PApplet.parseInt(random(1, 400)));
      redDragonList.add(redDragon);
    } else if (dragonType >= goldMinType && dragonType < 30) {  // gold dragon
      goldDragon = new DragonGold(PApplet.parseInt(random(120, 1080)), PApplet.parseInt(random(1100, 1500)), 150, 4, PApplet.parseInt(random(0, 40)));
      goldDragonList.add(goldDragon);
    }
  }

  public void collision() {
    // children of 'Enemy' class check collision
  }

  public boolean boolCollisionEnemy(Entity other) {  // detecting collision between enemies
    if (dist(other.x, other.y, this.x, this.y) < (this.size + 10)) {
      return true;
    } else {
      return false;
    }
  }
}  // end of 'Enemy' class
// enemy projectile

class EnemyProjectile extends Entity {
  // attributes
  boolean removeProjectile = false;

  // constructor
  EnemyProjectile(int x, int y, int size, int speed, boolean removeProjectile) {
    super(x, y, size, speed);
    this.removeProjectile = removeProjectile;
  }

  // methods
  public void render() {
    // update fireball animation counter
    animation.updateFireballCounter();
    // display new fireball images
    animation.fireballAnimation(x, y, size);
  }

  public void checkFireball() {  // check if a fireball should be created
    for (int i=0; i < redDragonList.size(); i++) {
      if (redDragonList.get(i).y < 1000 && redDragonList.get(i).y > 200) {  // if in range to shoot
        if (redDragonList.get(i).fireballCooldown == 0) {  // set active if cooldown is 0
          if (redDragonList.get(i).y > 400) {  // check if new fireball should be created
            enemyProjectile.createFireball(redDragonList.get(i).x, redDragonList.get(i).y);
          }
          redDragonList.get(i).fireballCooldown = 1000;  // new timer for fireball
        } else {
          if (redDragonList.get(i).fireballCooldown > 0) {  // reduce cooldown if not 0
            redDragonList.get(i).fireballCooldown--;
          }
        }
      }
    }
  }

  public void move() {
    if (this.y < 0) {
      fireballList.get(fireballList.indexOf(this)).removeProjectile = true;
    } else {
      this.y -= speed;
    }
  }

  public void createFireball(int x, int y) {  // declare a new fireball
    enemyProjectile = new EnemyProjectile(x, y-50, 75, 10, false);
    fireballList.add(enemyProjectile);
  }

  public void collision() {  // check for collisions between player and enemy projectile
    if (this.boolCollisionFireball(player) == true) {  // if fireball hits player
      // remove enemy and life when hit
      fireballList.remove(this);
      player.playerHealth(redDragon.damage);
    }
  }

  // returns true if collision occurs
  public boolean boolCollisionFireball(Entity other) {  // detecting collision between player and fireball
    if (dist(other.x, other.y, this.x, this.y) < other.size + 9) {
      return true;
    } else {
      return false;
    }
  }
}  // end of 'EnemyProjectile' class
// parent class

abstract class Entity {
  // Attributes
  int x;
  int y;
  int size;
  int speed;

  // Constructor
  Entity(int x, int y, int size, int speed) {
    this.x = x;
    this.y = y;
    this.size = size;
    this.speed = speed;
  }

  // Methods
  public void update() {
    render();
    move();
    collision();
  }

  public abstract void render();

  public abstract void move();

  public abstract void collision();
}  // end of 'Character' class
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
  public void createFile() {  // create new file (if file is not there)
    scoreboardFile = new File(dataPath(fileName));  // create file in game directory
  }

  public void appendFile() {  // write to file
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

  public void checkHighScore() {  // check the highest score within the txt file
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
// load images at beginning of the application to reduce lag

class LoadImages {
  // EnemyProjectile Images
  PImage[] fireballs = {loadImage("dragon_fireball//fireball_1.png"), loadImage("dragon_fireball//fireball_2.png"), loadImage("dragon_fireball//fireball_3.png"), loadImage("dragon_fireball//fireball_4.png")};
  // enemy death images
  PImage[] deathImage = {loadImage("poof//poof_1.png"), loadImage("poof//poof_2.png"), loadImage("poof//poof_3.png"), loadImage("poof//poof_4.png"), loadImage("poof//poof_5.png"), loadImage("poof//poof_6.png"), loadImage("poof//poof_7.png"), loadImage("poof//poof_8.png"), loadImage("poof//poof_9.png"), loadImage("poof//poof_10.png"), loadImage("poof//poof_11.png"), loadImage("poof//poof_12.png"), loadImage("poof//poof_13.png"), loadImage("poof//poof_14.png"), loadImage("poof//poof_15.png"), loadImage("poof//poof_16.png"), loadImage("poof//poof_17.png"), loadImage("poof//poof_18.png"), loadImage("poof//poof_19.png"), loadImage("poof//poof_20.png"), loadImage("poof//poof_21.png"), loadImage("poof//poof_22.png"), loadImage("poof//poof_23.png"), };
  // Animation Images
  PImage[] blue_dragon = {loadImage("dragons//blue_dragon_1.png"), loadImage("dragons//blue_dragon_2.png"), loadImage("dragons//blue_dragon_3.png")};
  PImage[] red_dragon = {loadImage("dragons//red_dragon_1.png"), loadImage("dragons//red_dragon_2.png"), loadImage("dragons//red_dragon_3.png")};
  PImage[] gold_dragon = {loadImage("dragons//gold_dragon_1.png"), loadImage("dragons//gold_dragon_2.png"), loadImage("dragons//gold_dragon_3.png")};
  PImage[] red_dragon_front = {loadImage("dragons//red_dragon_front_1.png"), loadImage("dragons//red_dragon_front_2.png"), loadImage("dragons//red_dragon_front_3.png")};
  PImage[] gold_dragon_mouse = {loadImage("dragons//gold_dragon_left_1.png"), loadImage("dragons//gold_dragon_left_2.png"), loadImage("dragons//gold_dragon_left_3.png")};
  // Player Images
  PImage player_witch_1 = loadImage("witch//witch_1.png");
  PImage player_witch_2 = loadImage("witch//witch_2.png");
  PImage player_cloud_1 = loadImage("cloud_1.png");
  // Projectile Images
  PImage[] randomImage = {loadImage("potions//potion_1.png"), loadImage("potions//potion_2.png"), loadImage("potions//potion_3.png"), loadImage("potions//potion_4.png"), loadImage("potions//potion_5.png"), loadImage("potions//potion_6.png")};
  // Display Images
  PImage heart = loadImage("heart.png");
  PImage grey_heart = loadImage("grey_heart.png");
  PImage backgroundImage = loadImage("background.png");
  PImage start = loadImage("text//start.png");
  PImage quit = loadImage("text//quit.png");
  PImage howToPlay = loadImage("text//how_to_play.png");
  PImage controls = loadImage("text//controls.png");
  PImage scoreboard = loadImage("text//scoreboard.png");
  PImage restart = loadImage("text//restart.png");
  PImage back = loadImage("text//back.png");
  PImage gameoverImage = loadImage("text//game_over.png");
  PImage submitImage = loadImage("text//submit.png");
}  // end of 'LoadImages' class
// Player class

class Player extends Entity {
  // Attributes
  boolean moveLeft = false;
  boolean moveRight = false;
  int playerLife = 3;
  int score = 0;
  int reloadTimer = 0;

  // Constructor
  Player(int x, int y, int size, int speed) {
    super(x, y, size, speed);
  }

  // Methods
  public void render() {  // rendering the player
    reloadTimer();
    // update animation counter
    animation.updatePlayerCounter();
    // update image
    animation.playerAnimation(x, y);
  }

  public void reloadTimer() {  // decrease timer value
    // reload timer
    if (player.reloadTimer > 0) {
      player.reloadTimer -= 1;
    }
  }

  public void move() {  // moving the player if they are within range
    if (moveLeft == true) {
      if (this.x > 75) {  // left border
        x -= speed;
      }
    }
    if (moveRight == true) {
      if (this.x < width - 75) {  // right border
        x += speed;
      }
    }
  }

  public void playerScore(int point) {  // update score
    score += point;
  }

  public void playerHealth(int damage) {  //  update health
    // remove a life
    playerLife -= damage;
    // check if player died
    if (player.playerLife == 0) {
      display.gameMode = 4;
    }
  }

  public void collision() {  // check collision between player and dragons
    for (int i = 0; i < blueDragonList.size(); i++) {  // blue dragon
      if (this.boolCollisionPlayer(blueDragonList.get(i)) == true) {  // if enemy hits player
        // remove and create a new enemy
        blueDragonList.remove(blueDragonList.get(i));
        enemy.createEnemy();
        // remove player life
        playerHealth(blueDragon.damage);
      }
    }
    for (int i = 0; i < redDragonList.size(); i++) {  // red dragon
      if (this.boolCollisionPlayer(redDragonList.get(i)) == true) {  // if enemy hits player
        // remove and create new enemy
        redDragonList.remove(redDragonList.get(i));
        enemy.createEnemy();
        // remove player life
        playerHealth(redDragon.damage);
      }
    }
    for (int i = 0; i < goldDragonList.size(); i++) {  // gold dragon
      if (this.boolCollisionPlayer(goldDragonList.get(i)) == true) {  // if enemy hits player
        // remove and create new enemy
        goldDragonList.remove(goldDragonList.get(i));
        enemy.createEnemy();
        // remove player life
        playerHealth(goldDragon.damage);
      }
    }
  }

  // returns true if collision occurs
  public boolean boolCollisionPlayer(Entity other) {  // detecting collision between player and enemy
    if (dist(other.x, other.y, this.x, this.y) < (other.size/2 + player.size/2)) {
      // add position of enemy to deathList
      deathAnimation = new DeathAnimation(other.x, other.y, 115);
      deathList.add(deathAnimation);
      return true;
    } else {
      return false;
    }
  }
}  // end of 'Player' class
// Projectile class

class Projectile extends Entity {
  // Attributes
  int imageType;
  int rotateType;
  float rotateImage;

  // Constructor
  Projectile(int x, int y, int size, int speed, int imageType, int rotateType) {
    super(x, y, size, speed);
    this.imageType = imageType;
    this.rotateType = rotateType;
  }

  // Methods
  public void render() {
    imageMode(CENTER);
    for (int i=0; i < loadImage.randomImage.length; i++) {
      loadImage.randomImage[i].resize(size, size);
    }
    // rotating the projectile image
    pushMatrix();  // open matrix temporarily
    translate(x, y);  // translate to new position
    rotateZ(rotateImage);
    translate(0, 0);  // translate to origional position
    image(loadImage.randomImage[imageType], 0, 0);
    popMatrix();  // close matrix
  }

  public void move() {
    if (this.y < 1000) {
      checkRotation();
      this.y += speed;
    } else {
      projectileList.remove(this);
    }
  }

  public void checkRotation() {  // increase angle of rotation depending on direction
    if (this.rotateType == 1) {
      if (rotateImage < 6.3f) {  // rotate image right
        rotateImage += 0.1f;
      } else {
        rotateImage = 0;
      }
    } else {
      if (rotateImage > -6.3f) {  // rotate image left
        rotateImage -= 0.1f;
      } else {
        rotateImage = 0;
      }
    }
  }

  public void collision() {  // collision between player projectile and enemies
    for (int i=0; i < blueDragonList.size(); i++) {  // blue dragon hit
      if (this.boolCollisionProjectile(blueDragonList.get(i)) == true) {
        // remove enemy
        blueDragonList.remove(blueDragonList.get(i));
        // add to score
        player.playerScore(blueDragon.point);
        // remove projectile
        projectileList.remove(this);
        // create new enemy
        enemy.createEnemy();
      }
    }
    for (int i=0; i < redDragonList.size(); i++) {  // blue dragon hit
      if (this.boolCollisionProjectile(redDragonList.get(i)) == true) {
        // remove enemy
        redDragonList.remove(redDragonList.get(i));
        // add to score
        player.playerScore(redDragon.point);
        // remove projectile
        projectileList.remove(this);
        // create new enemy
        enemy.createEnemy();
      }
    }
    for (int i=0; i < goldDragonList.size(); i++) {  // blue dragon hit
      if (this.boolCollisionProjectile(goldDragonList.get(i)) == true) {
        // remove enemy
        goldDragonList.remove(goldDragonList.get(i));
        // add to score
        player.playerScore(goldDragon.point);
        // remove projectile
        projectileList.remove(this);
        // create new enemy
        enemy.createEnemy();
      }
    }
  }

  // returns true if collision occurs
  public boolean boolCollisionProjectile(Entity other) {  // detecting collision between enemies
    if (dist(other.x, other.y, this.x, this.y) < (this.size - 5)) {
      // add position of enemy to deathList
      deathAnimation = new DeathAnimation(other.x, other.y, 115);
      deathList.add(deathAnimation);
      return true;
    } else {
      return false;
    }
  }
}  // end of 'Projectile' class
  public void settings() {  size(1200, 1000, P3D); }
  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "Siege_Game" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
