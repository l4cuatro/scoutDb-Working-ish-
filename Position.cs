using System;
using System.Math;

public class Position {
	double x,
		y,
		theta;
	int strafeEnc,
		frontEnc,
		strafeEncLast,
		frontEncLast,
		dt,
		moveBy,
		rotBy;
	bool holonomic;
		
	void moveForward(bool forward, bool back) {   //How far robot should move forward
		Position.frontEncLast = Position.frontEnc;
		Position.frontEnc += (forward ^ back)
			? (forward)
				? Position.moveBy
				: -Position.moveBy
			: 0;
	}
	
	void strafe(bool right, bool left) {				//How far robot should strafe
		Position.strafeEncLast = Position.strafeEnc;
		Position.strafeEnc += (left ^ right)
			? (right)
				? Position.moveBy
				: -Position.moveBy
			: 0;
	}
	
	void rotate(bool ccw, bool cw) {
		Position.theta += (ccw ^ cw)
			? (ccw)
				? Position.rotBy
				: -Position.rotBy
			: 0;
			
		theta = (abs(theta) % 360) *  Sign(theta);
	}
	
	void updatePos() {
		Position.x +=
			(Position.frontEnc - Position.frontEncLast) * Sin(Position.theta)
			+ (Position.strafeEnc - Position.strafeEncLast) * Cos(Position.theta);
		Position.y +=
			(Position.frontEnc - Position.frontEncLast) * Cos(Position.theta)
			+ (Position.strafeEnc - Position.strafeEncLast) * Sin(Position.theta);
	}
}
