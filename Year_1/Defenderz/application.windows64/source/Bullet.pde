// class to create the bullet

// global variable for shooting
boolean shoot;
color bulletColour = color(200, 100, 0);

class Bullet {
  int x = 50;
  int y = -20;  // default position is off screen to prevent 
  color bulletCollision;

  void update() {
    move();
    render();
  }

  void render() {
    fill(bulletColour);
    rect(x, y, 30, 10, 5);
  }

  void move() {  // moving the bullet
    x += 8;
    if (bullet.x > 770) {
      removeBullet();
    }
  }
  void removeBullet() {
    bullet = null;  // deleting bullet by setting its value to null
    shoot = false;
    bullet = new Bullet();  // creating a new object after old is deleted
  }
} // end of class
