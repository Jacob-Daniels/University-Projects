// class to create asteriods

// global variables to colour the asteroids
color asteroidBack = color(120, 120, 120);
color asteroidFront = color(150, 150, 150);
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

  void update() {
    move();
    render();
  }

  void render() { // rendering the asteroid
    // creating the shape and rotating it
    polygon(this.x, this.y, this.points, this.size);
    innerPolygon(this.x, this.y, this.points, this.size);  // inner drawing of asteroid
    innerPolygon2(this.x, this.y, this.points, this.size);  // second inner drawing of asteroid
  }

  void move() {  // moving the asteroid
    x -= this.speed;
    if (this.x < 0) {
      newAsteroid();
    }
  }

  void newAsteroid() {
    // resetting the values of the asteroid to create a new 'unique' one
    this.x = int(random(800, 1000));
    this.y = int(random(20, 380));
    this.points = int(random(5, 11));
    this.size = int(random(10, 21));
    this.speed = int(random(1, 4));
  }

  // methods to create the shape of each asteroid depending on values input
  void polygon(int x, int y, int points, int radius) {  // creating polygon
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
  void innerPolygon(int x, int y, int points, int radius) {  // creating polygon
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
  void innerPolygon2(int x, int y, int points, int radius) {  // creating polygon
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

  void explosionImage() {  // change image boolean variables when alien is hit
    // setting values to show image for number of frames
    asteroidImageBool = true;
    frameCounter = frameCount;
    // getting current x and y of alien ship
    asteroidImageX = this.x;
    asteroidImageY = this.y;
  }

  // boolean function to detect whether the bullet and asteroid have crashed
  boolean isShot(Bullet other) {
    if (abs(this.x - (other.x + 40)) < this.size && abs(this.y - other.y) < this.size) {  // are the bullet & asteroid within a certain range of eachother
      explosionImage();
      newAsteroid();
      return true;
    } else {
      return false;
    }
  } // end of class
}
