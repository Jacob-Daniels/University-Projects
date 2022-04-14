// creating a class for the alien

// global variables to colour the alien ship
color backAlien = color(0, 255, 0);
color frontAlien = color(50, 100, 0);
// Variables for alien explosion image
PImage alienExplosion;
boolean alienExplosionBool;
int alienImageX;
int alienImageY;

class Alien {
  int x;
  int y;
  int speedY;
  color bulletCollision;
  // alien light colours
  color leftRed = color(255);
  color leftGreen = color(255);
  color leftBlue = color(255);
  color rightRed = color(255);
  color rightGreen = color(255);
  color rightBlue = color(255);
  color middleRed = color(255);
  color middleGreen = color(255);
  color middleBlue = color(255);

  // constructor
  Alien(int x, int y) {
    this.x = x;
    this.y = y;
  }

  // methods
  void update() {
    render();
    move();
  }

  void render() {
    // creating the alien ship
    fill(backAlien); 
    ellipse(x, y, 30, 30); 
    fill(frontAlien); 
    ellipse(x, y, 50, 15);
    // creating lights for the alien ship
    if (frameCount % 15 == 0) {
      middleRed = int(random(256));
      middleGreen = int(random(256));
      middleBlue = int(random(256));
    }
    fill(middleRed, middleGreen, middleBlue); 
    ellipse(x, y, 5, 5);  // middle light
    if (frameCount % 10 == 0) {
      leftRed = int(random(256));
      leftGreen = int(random(256));
      leftBlue = int(random(256));
    }
    fill(leftRed, leftGreen, leftBlue); 
    ellipse(x - 10, y, 5, 5);  // left light
    if (frameCount % 20 == 0) {
      rightRed = int(random(256));
      rightGreen = int(random(256));
      rightBlue = int(random(256));
    }
    fill(rightRed, rightGreen, rightBlue); 
    ellipse(x + 10, y, 5, 5);  // right light
  }

  // moving the aliens position
  void move() {
    if (x > 0) {  // checks to see if the alien has left the screen
      x = x - int(random(5));
      speedY = int(random(3));
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
      y = int(random(15, 385));
    }
  }

  // methods to move the direction Y up/down
  void moveUP() {
    y = y - int(random(4));
  }

  void moveDOWN() {
    y = y + int(random(4));
  }

  // reset alien position when hit by bullet
  void newAlien() {
    this.x = int(random(800, 1000));
    this.y = int(random(15, 385));
  }

  void explosionImage() {  // change image boolean variables when alien is hit
    // setting values to show image for number of frames
    alienExplosionBool = true;
    frameCounter = frameCount;
    // getting current x and y of alien ship
    alienImageX = this.x;
    alienImageY = this.y;
  }

  // checking if the alien is shot by the bullet
  boolean isShot(Bullet other) {
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
