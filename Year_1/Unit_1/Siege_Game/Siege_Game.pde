
// importing library
import java.io.*;  // file class
import java.util.*;  // scanner class
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

void setup() {
  size(1200, 1000, P3D);
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

void draw() {
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
void keyPressed() {
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
          projectile = new Projectile(player.x - 30, player.y, 60, 7, int(random(6)), int(random(1, 3)));
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
void keyReleased() {
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

void mousePressed() {
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
        projectile = new Projectile(player.x - 30, player.y, 60, 7, int(random(6)), int(random(1, 3)));
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

void createObjects() {  // creating objects for each class
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
void updateObjects() {
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
