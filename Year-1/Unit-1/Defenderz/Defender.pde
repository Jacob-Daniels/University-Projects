// creating a class for the defender

boolean boolUP;
boolean boolDOWN;
boolean boolShoot;

class Defender {
  int x = 30;  // giving x a default value of 30
  int y;
  color defenderCollision;

  Defender(int y) {  // constructor
    this.y = y;
  }

  void update() {
    render();
    canShoot();
  }

  // methods
  void render() {  // creating the defender
    stroke(0);
    //draw top box
    fill(#666666);
    rect(x, y, 20, 10);
    //draw rocket
    fill(#595959);
    rect(x, y+10, 50, 20); 
    triangle(x+50, y+10, x+50, y+30, x+60, y+20);
    // changing colour if player can shoot
  }

  void canShoot() {  // change colour of defender when player can shoot again
    if (shoot == false) {
      fill(0, 255, 0);
    } else {
      fill(255, 0, 0);
    }
    rect(x + 5, y + 15, 40, 8);
  }

  void playerMove() {  // move rocket/defender when key pressed
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

  void playerShoot() {
    if (boolShoot == true) {  // shoot if key is pressed
      if (shoot == false) {
        bullet.y = player.y;
        shoot = true;
      }
    }
  }

  // creating the point to detect colour collision
  boolean drawCrashLine() {
    for (int i=1; i<=20; i++) {
      defenderCollision = get(x + 62, (y+10) + i); // getting colour of a point
      if (defenderCollision == backAlien || defenderCollision == frontAlien || defenderCollision == asteroidBack) { // has alien / asteroid colour come into contact with the defender
        return true;
      }
    }
    return false;
  }
} // end of class
