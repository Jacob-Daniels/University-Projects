import processing.core.*; 
import processing.data.*; 
import processing.event.*; 
import processing.opengl.*; 

import java.util.HashMap; 
import java.util.ArrayList; 
import java.io.File; 
import java.io.BufferedReader; 
import java.io.PrintWriter; 
import java.io.InputStream; 
import java.io.OutputStream; 
import java.io.IOException; 

public class Defenderz extends PApplet {

// creating a defenderz game

//global variables and importing image to variable for background
PImage background;
int bgX=0;
// game score variables
int timer;
int score;
// framecounter is used to display explosion images on screen for a number of frames.
int frameCounter;

// referencing the class
Defender player;
Alien alien1;
Alien alien2;
Alien alien3;
Alien alien4;
Alien alien5;
Bullet bullet;
Asteroid asteroid1;
Asteroid asteroid2;
Asteroid asteroid3;
Asteroid asteroid4;

// creating an arraylist for the asteroids
ArrayList<Asteroid> asteroidList = new ArrayList<Asteroid>();


public void setup() { 
   
  // declaring image to variables
  background = loadImage("spaceBackground.jpg"); 
  background.resize(width, height); //set image to be same size as the canvas
  alienExplosion = loadImage("explosion.png"); 
  alienExplosion.resize(width/8, height/8); 
  asteroidExplosion = loadImage("poof.png");
  asteroidExplosion.resize(width/12, height/8);
  // calling to procedure to create objects for the classes
  gameStart();
}

public void draw () { 
  // move background
  drawBackground();
  // if first frame then stop game from starting until key pressed & setup objects
  if (frameCount <= 1) {
    gameStart();
  }
  
  // make asteroids using ArrayList
  for (int i=0; i<asteroidList.size(); i++) {
    asteroidList.get(i).update();
  }
  
  // displaying score
  totalScore();
  // add seconds to timer
  timer();
  // update objects
  renderObjects();
  // showing image if alien or asteroid is destroyed
  alienDestroyedImage();
  asteroidDestroyedImage();
  // bullet been shot procedure
  bulletShot();
  // bullet hitting alien/asteroid procedure
  bulletHit();
  // checking for collision with defender and alien
  crashed();
  // check key press
  checkKeys();
}

public void makeAsteroids() {  // procedure to make list of asteroids
  Asteroid asteroidObject;
  for (int object=1; object<=10; object++) {
    asteroidObject = new Asteroid(PApplet.parseInt(random(800, 1000)), PApplet.parseInt(random(20, 380)), PApplet.parseInt(random(5, 11)), PApplet.parseInt(random(10, 21)), PApplet.parseInt(random(1, 4)));
    asteroidList.add(asteroidObject);
  }
}


// key functions
public void keyPressed() {  // change boolean value when key pressed
  if (key == CODED) {
    if (keyCode == UP) {
      boolUP = true;
    } 
    if (keyCode == DOWN) {
      boolDOWN = true;
    }
  }
  if (key == 32) {  // 'space' key to shoot
    boolShoot = true;
    player.playerShoot();
  }
  if (key == 115) {  // 's' key to start the game
    loop();
  }
}

public void keyReleased() {  // change boolean values when key released
  if (key == CODED) {
    if (keyCode == UP) {  // move the defender using arrow 'UP' and 'DOWN' keys
      boolUP = false;
    } 
    if (keyCode == DOWN) {
      boolDOWN = false;
    }
    if (key == 32) {  // 'space' key to shoot
      bullet.y = player.y;
      boolShoot = false;
      player.playerShoot();
    }
  }
}

public void checkKeys() {  // allow the player to move and shoot at the same time by assigning key press to boolean variables
  if (boolUP == true) {
    player.playerMove();
  }
  if (boolDOWN == true) {
    player.playerMove();
  }
}

// Procedures

public void renderObjects() {  // update all objects to be displayed on screen
  // rendering the objects on screen
  player.update();
  alien1.update();
  alien2.update();
  alien3.update();
  alien4.update();
  alien5.update();
  asteroid1.update();
  asteroid2.update();
  asteroid3.update();
  asteroid4.update();
}

// checking whether crash has occured (with bullet)
public void bulletHit() {
  // checking if bullet has hit alien
  if (alien1.isShot(bullet) == true) {
    bullet.removeBullet();
  } else if (alien2.isShot(bullet) == true) {
    bullet.removeBullet();
  } else if (alien3.isShot(bullet) == true) {
    bullet.removeBullet();
  } else if (alien4.isShot(bullet) == true) {
    bullet.removeBullet();
  } else if (alien5.isShot(bullet) == true) {
    bullet.removeBullet();
  }
  // checking if the bullet has hit the asteroid
  if (asteroid1.isShot(bullet) == true) {
    bullet.removeBullet();
  } else if (asteroid2.isShot(bullet) == true) {
    bullet.removeBullet();
  } else if (asteroid3.isShot(bullet) == true) {
    bullet.removeBullet();
  } else if (asteroid4.isShot(bullet) == true) {
    bullet.removeBullet();
  }
  // arrayList asteroids collision with bullet
  for (int i=0; i<asteroidList.size(); i++) {
    if (asteroidList.get(i).isShot(bullet)) {
      bullet.removeBullet();
    }
  }
}

public void crashed() {  // end the game if crash occurs
  if (player.drawCrashLine() == true) {
    // filling background to display final score
    fill(0);
    rect(0, 0, 800, 400);
    // displaying text for score and 'game over'
    textSize(30);
    fill(255, 0, 0);
    textAlign(CENTER);
    text("GAME OVER!", width/2, (height/2) - 60);
    fill(255);
    text("Time: " + timer + " seconds", width/2, (height/2));
    text("Score: " + score, width/2, (height/2) + 40);
    text("Press 's' to play again!", width/2, (height/2) + 100);
    // reset game
    resetGame();
    noLoop();
  }
}

public void alienDestroyedImage() {  // display image if alien is destroyed
  // displaying explosion image for selected number of frames
  if (alienExplosionBool == true) {
    if (frameCount <= frameCounter + 10) {
      // display explosion image
      imageMode(CENTER);
      image(alienExplosion, alienImageX, alienImageY);
    } else {
      alienExplosionBool = false;
    }
  }
}

public void asteroidDestroyedImage() {  // display image if asteroid is destroyed
  // displaying 'poof' image for selected number of frames
  if (asteroidImageBool == true) {
    if (frameCount <= frameCounter + 10) {
      // display explosion image
      imageMode(CENTER);
      image(asteroidExplosion, asteroidImageX, asteroidImageY);
    } else {
      asteroidImageBool = false;
    }
  }
}

public void bulletShot() {  // make defender shoot bullet
  // if bullet shot, then move bullet
  if (shoot == true) {
    bullet.update();
  }
}

// procedures to setup game score, time and background
public void drawBackground() {  // moving the background image from right to left
  imageMode(CORNER);
  //scrolling background image 
  image(background, bgX, 0); //draw image to fill the canvas 
  //draw image again off the right of the canvas 
  image(background, bgX+background.width, 0);     
  bgX = bgX- 4; 

  if (bgX == -background.width) { //if first image completely off the canvas
    bgX=0; //reset back to initial value background
  }
}

public void totalScore() {  // display score on screen
  fill(255, 0, 0);
  textSize(25);
  text(score, width/2, 50);
}

public void timer() {  // add 1s to the timer every 60 frames
  if (frameCount % 60 == 0) {
    timer +=1;
  }
}

public void gameStart() {  // setup objects for game
  // creating objects to pass into the classes
  // defender
  player = new Defender(200);
  // alien
  alien1 = new Alien(800, 200);
  alien2 = new Alien(1000, 350);
  alien3 = new Alien(1000, 50);
  alien4 = new Alien(1200, 150);
  alien5 = new Alien(1200, 300);
  // bullet
  bullet = new Bullet();
  // asteroid
  asteroid1 = new Asteroid(PApplet.parseInt(random(800, 1000)), PApplet.parseInt(random(20, 380)), PApplet.parseInt(random(5, 11)), PApplet.parseInt(random(10, 21)), PApplet.parseInt(random(1, 4)));
  asteroid2 = new Asteroid(PApplet.parseInt(random(800, 1000)), PApplet.parseInt(random(20, 380)), PApplet.parseInt(random(5, 11)), PApplet.parseInt(random(10, 21)), PApplet.parseInt(random(1, 4)));
  asteroid3 = new Asteroid(PApplet.parseInt(random(800, 1000)), PApplet.parseInt(random(20, 380)), PApplet.parseInt(random(5, 11)), PApplet.parseInt(random(10, 21)), PApplet.parseInt(random(1, 4)));
  asteroid4 = new Asteroid(PApplet.parseInt(random(800, 1000)), PApplet.parseInt(random(20, 380)), PApplet.parseInt(random(5, 11)), PApplet.parseInt(random(10, 21)), PApplet.parseInt(random(1, 4)));
  // asteroids in ArrayList
  if (frameCount % 60 == 0) {
    makeAsteroids();
  }
  // text on screen how to start the game
  textSize(20); 
  fill(255, 0, 0);
  textAlign(CENTER);
  text("Press 's' to start", width/2, height/2);
  // removing bug of bullet being able to be rendered by player when game has not started
  bullet.removeBullet();
  // preventing game from starting
  noLoop();
}

public void resetGame() {  // resetting the game values once game has ended
  // reset framerate/scores for new game
  frameCount = 0;
  score = 0;
  timer = 0;
  asteroidList.clear();
}
// creating a class for the alien

// global variables to colour the alien ship
int backAlien = color(0, 255, 0);
int frontAlien = color(50, 100, 0);
// Variables for alien explosion image
PImage alienExplosion;
boolean alienExplosionBool;
int alienImageX;
int alienImageY;

class Alien {
  int x;
  int y;
  int speedY;
  int bulletCollision;
  // alien light colours
  int leftRed = color(255);
  int leftGreen = color(255);
  int leftBlue = color(255);
  int rightRed = color(255);
  int rightGreen = color(255);
  int rightBlue = color(255);
  int middleRed = color(255);
  int middleGreen = color(255);
  int middleBlue = color(255);

  // constructor
  Alien(int x, int y) {
    this.x = x;
    this.y = y;
  }

  // methods
  public void update() {
    render();
    move();
  }

  public void render() {
    // creating the alien ship
    fill(backAlien); 
    ellipse(x, y, 30, 30); 
    fill(frontAlien); 
    ellipse(x, y, 50, 15);
    // creating lights for the alien ship
    if (frameCount % 15 == 0) {
      middleRed = PApplet.parseInt(random(256));
      middleGreen = PApplet.parseInt(random(256));
      middleBlue = PApplet.parseInt(random(256));
    }
    fill(middleRed, middleGreen, middleBlue); 
    ellipse(x, y, 5, 5);  // middle light
    if (frameCount % 10 == 0) {
      leftRed = PApplet.parseInt(random(256));
      leftGreen = PApplet.parseInt(random(256));
      leftBlue = PApplet.parseInt(random(256));
    }
    fill(leftRed, leftGreen, leftBlue); 
    ellipse(x - 10, y, 5, 5);  // left light
    if (frameCount % 20 == 0) {
      rightRed = PApplet.parseInt(random(256));
      rightGreen = PApplet.parseInt(random(256));
      rightBlue = PApplet.parseInt(random(256));
    }
    fill(rightRed, rightGreen, rightBlue); 
    ellipse(x + 10, y, 5, 5);  // right light
  }

  // moving the aliens position
  public void move() {
    if (x > 0) {  // checks to see if the alien has left the screen
      x = x - PApplet.parseInt(random(5));
      speedY = PApplet.parseInt(random(3));
      if (speedY == 1) {  // moving the ship up or down randomly
        if (y < 15) {  // change Y direction
          moveDOWN();
        } else {
          moveUP();
        }
      } else if (speedY == 2) {
        if (y > 385) {
          moveUP();
        } else {
          moveDOWN();
        }
      }
    } else {  // resetting the aliens x position
      x = 800;
      y = PApplet.parseInt(random(15, 385));
    }
  }

  // methods to move the direction Y up/down
  public void moveUP() {
    y = y - PApplet.parseInt(random(4));
  }

  public void moveDOWN() {
    y = y + PApplet.parseInt(random(4));
  }

  // reset alien position when hit by bullet
  public void newAlien() {
    this.x = PApplet.parseInt(random(800, 1000));
    this.y = PApplet.parseInt(random(15, 385));
  }

  public void explosionImage() {  // change image boolean variables when alien is hit
    // setting values to show image for number of frames
    alienExplosionBool = true;
    frameCounter = frameCount;
    // getting current x and y of alien ship
    alienImageX = this.x;
    alienImageY = this.y;
  }

  // checking if the alien is shot by the bullet
  public boolean isShot(Bullet other) {
    if (abs(this.x - (other.x + 40)) < 10 && abs(this.y - other.y) < 20) {  // is the bullet & alien within a certain range of eachother
      // displaying explosion image where alien was hit
      explosionImage();
      // resetting alien position
      newAlien();
      // increasing score by 1
      score += 1;
      return true;
    } else {
      return false;
    }
    //return (abs(this.x - (other.x + 30)) < 25 && abs(this.y - other.y) < 15);
  }
} // end of class
// class to create asteriods

// global variables to colour the asteroids
int asteroidBack = color(120, 120, 120);
int asteroidFront = color(150, 150, 150);
// variables for the asteroid explosion
PImage asteroidExplosion;
boolean asteroidImageBool;
int asteroidImageX;
int asteroidImageY;

class Asteroid {
  int x;
  int y;
  int points;
  int size;
  int speed;

  // constructor
  Asteroid(int x, int y, int points, int size, int speed) {
    this.x = x;
    this.y = y;
    this.points = points;
    this.size = size;
    this.speed = speed;
  }

  public void update() {
    move();
    render();
  }

  public void render() { // rendering the asteroid
    // creating the shape and rotating it
    polygon(this.x, this.y, this.points, this.size);
    innerPolygon(this.x, this.y, this.points, this.size);  // inner drawing of asteroid
    innerPolygon2(this.x, this.y, this.points, this.size);  // second inner drawing of asteroid
  }

  public void move() {  // moving the asteroid
    x -= this.speed;
    if (this.x < 0) {
      newAsteroid();
    }
  }

  public void newAsteroid() {
    // resetting the values of the asteroid to create a new 'unique' one
    this.x = PApplet.parseInt(random(800, 1000));
    this.y = PApplet.parseInt(random(20, 380));
    this.points = PApplet.parseInt(random(5, 11));
    this.size = PApplet.parseInt(random(10, 21));
    this.speed = PApplet.parseInt(random(1, 4));
  }

  // methods to create the shape of each asteroid depending on values input
  public void polygon(int x, int y, int points, int radius) {  // creating polygon
    double angle = TWO_PI / points;  // getting the size of one angle within the polygon
    beginShape();
    fill(asteroidBack);
    for (float i=0; i < TWO_PI; i += angle) {  // iterating until angle reaches max degree
      float xSide = x + cos(i) * radius;  // getting the points for the vertex line
      float ySide = y + sin(i) * radius;
      vertex(xSide, ySide);
    }
    endShape(CLOSE);
  }
  // smaller asteroid within the larger one
  public void innerPolygon(int x, int y, int points, int radius) {  // creating polygon
    double angle = TWO_PI / points;  // getting the size of one angle within the polygon
    beginShape();
    fill(asteroidFront);
    for (float i=0; i < TWO_PI; i += angle) {  // iterating until angle reaches max degree
      float xSide = x-(radius/3) + cos(i) * (radius/2);  // getting the points for the vertex line
      float ySide = y-(radius/3) + sin(i) * (radius/3);
      vertex(xSide, ySide);
    }
    endShape(CLOSE);
  }
  // other small asteroid within the larger one
  public void innerPolygon2(int x, int y, int points, int radius) {  // creating polygon
    double angle = TWO_PI / points;  // getting the size of one angle within the polygon
    beginShape();
    fill(asteroidFront);
    for (float i=0; i < TWO_PI; i += angle) {  // iterating until angle reaches max degree
      float xSide = x+(radius/3) + cos(i) * (radius/5);  // getting the points for the vertex line
      float ySide = y+(radius/3) + sin(i) * (radius/4);
      vertex(xSide, ySide);
    }
    endShape(CLOSE);
  }

  public void explosionImage() {  // change image boolean variables when alien is hit
    // setting values to show image for number of frames
    asteroidImageBool = true;
    frameCounter = frameCount;
    // getting current x and y of alien ship
    asteroidImageX = this.x;
    asteroidImageY = this.y;
  }

  // boolean function to detect whether the bullet and asteroid have crashed
  public boolean isShot(Bullet other) {
    if (abs(this.x - (other.x + 40)) < this.size && abs(this.y - other.y) < this.size) {  // are the bullet & asteroid within a certain range of eachother
      explosionImage();
      newAsteroid();
      return true;
    } else {
      return false;
    }
  } // end of class
}
// class to create the bullet

// global variable for shooting
boolean shoot;
int bulletColour = color(200, 100, 0);

class Bullet {
  int x = 50;
  int y = -20;  // default position is off screen to prevent 
  int bulletCollision;

  public void update() {
    move();
    render();
  }

  public void render() {
    fill(bulletColour);
    rect(x, y, 30, 10, 5);
  }

  public void move() {  // moving the bullet
    x += 8;
    if (bullet.x > 770) {
      removeBullet();
    }
  }
  public void removeBullet() {
    bullet = null;  // deleting bullet by setting its value to null
    shoot = false;
    bullet = new Bullet();  // creating a new object after old is deleted
  }
} // end of class
// creating a class for the defender

boolean boolUP;
boolean boolDOWN;
boolean boolShoot;

class Defender {
  int x = 30;  // giving x a default value of 30
  int y;
  int defenderCollision;

  Defender(int y) {  // constructor
    this.y = y;
  }

  public void update() {
    render();
    canShoot();
  }

  // methods
  public void render() {  // creating the defender
    stroke(0);
    //draw top box
    fill(0xff666666);
    rect(x, y, 20, 10);
    //draw rocket
    fill(0xff595959);
    rect(x, y+10, 50, 20); 
    triangle(x+50, y+10, x+50, y+30, x+60, y+20);
    // changing colour if player can shoot
  }

  public void canShoot() {  // change colour of defender when player can shoot again
    if (shoot == false) {
      fill(0, 255, 0);
    } else {
      fill(255, 0, 0);
    }
    rect(x + 5, y + 15, 40, 8);
  }

  public void playerMove() {  // move rocket/defender when key pressed
    if (boolUP == true) {
      if (player.y < 10) {  // setting top boundary for defender
        player.y = 0;
      } else {
        player.y -= 3;
      }
    } 
    if (boolDOWN == true) {
      if (player.y > 360) {  // setting bottom boundary for defender
        player.y = 370;
      } else {
        player.y += 3;
      }
    }
  }

  public void playerShoot() {
    if (boolShoot == true) {  // shoot if key is pressed
      if (shoot == false) {
        bullet.y = player.y;
        shoot = true;
      }
    }
  }

  // creating the point to detect colour collision
  public boolean drawCrashLine() {
    for (int i=1; i<=20; i++) {
      defenderCollision = get(x + 62, (y+10) + i); // getting colour of a point
      if (defenderCollision == backAlien || defenderCollision == frontAlien || defenderCollision == asteroidBack) { // has alien / asteroid colour come into contact with the defender
        return true;
      }
    }
    return false;
  }
} // end of class
  public void settings() {  size(800, 400); }
  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "Defenderz" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
