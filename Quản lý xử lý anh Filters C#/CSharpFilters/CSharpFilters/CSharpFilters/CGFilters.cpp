// XTFilters.cpp: implementation of the CXTFilters class.
//
//////////////////////////////////////////////////////////////////////

#include "stdafx.h"
#include "CGBitmap.h"

#include <math.h>
#include <vector>
#include <deque>
#include <algorithm>
#include <numeric>
#include <time.h>

#include "CGFilters.h"
#include "assert.h"

#ifdef _DEBUG
#undef THIS_FILE
static char THIS_FILE[]=__FILE__;
#define new DEBUG_NEW
#endif

//////////////////////////////////////////////////////////////////////
// Construction/Destruction
//////////////////////////////////////////////////////////////////////

#define mid(a,b,c) ((((a>b) ? a : b)>c) ? c : max(a,b))

const double RadToDeg = 180/3.1415;

const short CGFilters::FILTER_NONE = 0;
const short CGFilters::FILTER_BILINEAR = 1;

const short CGFilters::EDGE_DETECT_QUICK		= 0;
const short CGFilters::EDGE_DETECT_KIRSH		= 1;
const short CGFilters::EDGE_DETECT_PREWITT		= 2;
const short CGFilters::EDGE_DETECT_SOBEL		= 3;
const short CGFilters::EDGE_DETECT_DIFFERENCE	= 4;
const short CGFilters::EDGE_DETECT_HOMOGENITY	= 5;
const short CGFilters::EDGE_DETECT_HORZ			= 6;
const short CGFilters::EDGE_DETECT_VERT			= 7;

const short CGFilters::HIST_RED		= 0;
const short CGFilters::HIST_GREEN	= 1;
const short CGFilters::HIST_BLUE	= 2;
const short CGFilters::HIST_ALL		= 3;

bool CGFilters::m_bInit = false;
double CGFilters::m_nSin[360];
double CGFilters::m_nCos[360];

void CGFilters::Swirl(CGBitmap * pBmp, double fDegree, short smoothing)
{
//	if (false == m_bInit) Init();

	int nWidth = pBmp->GetWidth(), nHeight = pBmp->GetHeight();

	POINT ** ppPoint = new POINT * [nWidth];
	FLOATPOINT ** ppFPoint = new FLOATPOINT * [nWidth];

	for (int i = 0; i < nWidth; ++i)
	{
		ppFPoint[i] = new FLOATPOINT[nHeight];
		ppPoint[i] = new POINT[nHeight];
	}

	POINT mid;
	mid.x = nWidth/2;
	mid.y = nHeight/2;

	POINT pt;
	pt.x = pt.y = 0;
	double theta, radius;
	double newX, newY;

	for (int x = 0; x < nWidth; ++x)
		for (int y = 0; y < nHeight; ++y)
		{
			int trueX = x - mid.x;
			int trueY = y - mid.y;
			theta = atan2((trueY),(trueX));

			radius = sqrt(trueX*trueX + trueY*trueY);

//			newX = mid.x + (int)(radius * m_nCos[int(theta * RadToDeg)*10]);// + fDegree * radius)]);
			newX = mid.x + (radius * cos(theta + fDegree * radius));
			if (newX > 0 && newX < nWidth)
				ppPoint[x][y].x = ppFPoint[x][y]. x = newX;
			else
				ppPoint[x][y].x = ppFPoint[x][y].x = x;

//			newY = mid.y + (int)(radius * m_nSin[int(theta * RadToDeg)*10]);// + fDegree * radius)]);
			newY = mid.y + (radius * sin(theta + fDegree * radius));
			if (newY > 0 && newY < nHeight)
				ppPoint[x][y].y = ppFPoint[x][y].y = newY;
			else
				ppPoint[x][y].y = ppFPoint[x][y].y = y;
		}

	switch(smoothing)
	{
	case FILTER_NONE:
		CGFilters::OffsetFilterAbs(pBmp, ppPoint);		
		break;
	case FILTER_BILINEAR:
		CGFilters::OffsetFilterAntiAlias(pBmp, ppFPoint);		
		break;
	default:
		// Means that an inappropriate value was passed for smoothing)
		assert(false);
	}

	for (int j = 0; j < pBmp->GetWidth(); ++j)
	{
		delete [] ppPoint[j];
		delete [] ppFPoint[j];
	}

	delete [] ppPoint;
	delete [] ppFPoint;
}

void CGFilters::Sphere(CGBitmap * pBmp, short smoothing)
{
	int nWidth = pBmp->GetWidth(), nHeight = pBmp->GetHeight();

	POINT ** ppPoint = new POINT * [nWidth];
	FLOATPOINT ** ppFPoint = new FLOATPOINT * [nWidth];

	for (int i = 0; i < nWidth; ++i)
	{
		ppFPoint[i] = new FLOATPOINT[nHeight];
		ppPoint[i] = new POINT[nHeight];
	}

	POINT mid;
	mid.x = nWidth/2;
	mid.y = nHeight/2;

	POINT pt;
	pt.x = pt.y = 0;
	double theta, radius;
	double newX, newY;

	for (int x = 0; x < nWidth; ++x)
		for (int y = 0; y < nHeight; ++y)
		{
			int trueX = x - mid.x;
			int trueY = y - mid.y;
			theta = atan2((trueY),(trueX));

			radius = sqrt(trueX*trueX + trueY*trueY);

			double newRadius = radius * radius/(max(mid.x, mid.y));

			newX = mid.x + (newRadius * cos(theta));

			if (newX > 0 && newX < nWidth)
				ppPoint[x][y].x = ppFPoint[x][y].x = newX;
			else
			{
				ppPoint[x][y].y = ppFPoint[x][y].y = 0;
				ppPoint[x][y].x = ppFPoint[x][y].x = 0;
			}

			newY = mid.y + (newRadius * sin(theta));

			if (newY > 0 && newY < nHeight && newX > 0 && newX < nWidth)
				ppPoint[x][y].y = ppFPoint[x][y].y = newY;
			else
			{
				ppPoint[x][y].y = ppFPoint[x][y].y = 0;
				ppPoint[x][y].x = ppFPoint[x][y].x = 0;
			}
		}


	switch(smoothing)
	{
	case FILTER_NONE:
		CGFilters::OffsetFilterAbs(pBmp, ppPoint);		
		break;
	case FILTER_BILINEAR:
		CGFilters::OffsetFilterAntiAlias(pBmp, ppFPoint);		
		break;
	default:
		// Means that an inappropriate value was passed for smoothing)
		assert(false);
	}		

	for (int j = 0; j < pBmp->GetWidth(); ++j)
	{
		delete [] ppPoint[j];
		delete [] ppFPoint[j];
	}

	delete [] ppPoint;
	delete [] ppFPoint;
}

void CGFilters::TimeWarp(CGBitmap * pBmp, BYTE factor, short smoothing)
{
	int nWidth = pBmp->GetWidth(), nHeight = pBmp->GetHeight();

	POINT ** ppPoint = new POINT * [nWidth];
	FLOATPOINT ** ppFPoint = new FLOATPOINT * [nWidth];

	for (int i = 0; i < nWidth; ++i)
	{
		ppFPoint[i] = new FLOATPOINT[nHeight];
		ppPoint[i] = new POINT[nHeight];
	}

	POINT mid;
	mid.x = nWidth/2;
	mid.y = nHeight/2;

	POINT pt;
	pt.x = pt.y = 0;
	double theta, radius;
	double newX, newY;

	for (int x = 0; x < nWidth; ++x)
		for (int y = 0; y < nHeight; ++y)
		{
			int trueX = x - mid.x;
			int trueY = y - mid.y;
			theta = atan2((trueY),(trueX));

			radius = sqrt(trueX*trueX + trueY*trueY);

			double newRadius = sqrt(radius) * factor;

			newX = mid.x + (newRadius * cos(theta));
			if (newX > 0 && newX < nWidth)
				ppPoint[x][y].x = ppFPoint[x][y].x = newX;
			else
				ppPoint[x][y].x = ppFPoint[x][y].x = 0;

			newY = mid.y + (newRadius * sin(theta));
			if (newY > 0 && newY < nHeight)
				ppPoint[x][y].y = ppFPoint[x][y].y = newY;
			else
				ppPoint[x][y].y = ppFPoint[x][y].y = 0;
		}

	switch(smoothing)
	{
	case FILTER_NONE:
		CGFilters::OffsetFilterAbs(pBmp, ppPoint);	
		break;
	case FILTER_BILINEAR:
		CGFilters::OffsetFilterAntiAlias(pBmp, ppFPoint);	
		break;
	default:
		// Means that an inappropriate value was passed for smoothing)
		assert(false);
	}		

	for (int j = 0; j < pBmp->GetWidth(); ++j)
	{
		delete [] ppPoint[j];
		delete [] ppFPoint[j];
	}

	delete [] ppPoint;
	delete [] ppFPoint;
}

void CGFilters::Moire(CGBitmap * pBmp, double fDegree)
{
	POINT ** ppPoint = new POINT * [pBmp->GetWidth()];

	for (int i = 0; i < pBmp->GetWidth(); ++i)
		ppPoint[i] = new POINT[pBmp->GetHeight()];

	int nWidth = pBmp->GetWidth(), nHeight = pBmp->GetHeight();

	POINT mid;
	mid.x = nWidth/2;
	mid.y = nHeight/2;

	POINT pt;
	pt.x = pt.y = 0;
	double theta, radius;
	int newX, newY;

	for (int x = 0; x < nWidth; ++x)
		for (int y = 0; y < nHeight; ++y)
		{
			int trueX = x - mid.x;
			int trueY = y - mid.y;
			theta = atan2((trueX),(trueY));

			radius = sqrt(trueX*trueX + trueY*trueY);

			newX = (int)(radius * sin(theta + fDegree * radius));
			if (newX > 0 && newX < nWidth)
				ppPoint[x][y].x = newX - x;
			else
				ppPoint[x][y].x = 0;

			newY = (int)(radius * sin(theta + fDegree * radius));
			if (newY > 0 && newY < nHeight)
				ppPoint[x][y].y = newY - y;
			else
				ppPoint[x][y].y = 0;
		}

	CGFilters::OffsetFilter(pBmp, ppPoint);		

	for (int j = 0; j < pBmp->GetWidth(); ++j)
		delete [] ppPoint[j];

	delete [] ppPoint;
}

void CGFilters::Water(CGBitmap * pBmp, short nWave, short smoothing /*= CGFilters::FILTER_NONE*/)
{
//	if (!m_bInit) Init();

	int nWidth = pBmp->GetWidth(), nHeight = pBmp->GetHeight();

	POINT ** ppPoint = new POINT * [nWidth];
	FLOATPOINT ** ppFPoint = new FLOATPOINT * [nWidth];

	for (int i = 0; i < nWidth; ++i)
	{
		ppFPoint[i] = new FLOATPOINT[nHeight];
		ppPoint[i] = new POINT[nHeight];
	}

	double newX, newY;
	double xo, yo;

	for (int x = 0; x < nWidth; ++x)
		for (int y = 0; y < nHeight; ++y)
		{
			xo = ((double)nWave * sin(2.0 * 3.1415 * (float)y / 128.0));
			yo = ((double)nWave * cos(2.0 * 3.1415 * (float)x / 128.0));

			newX = (x + xo);
			newY = (y + yo);

			if (newX > 0 && newX < nWidth)
				ppPoint[x][y].x = ppFPoint[x][y].x = newX;
			else
				ppPoint[x][y].x = ppFPoint[x][y].x = 0;

			if (newY > 0 && newY < nHeight)
				ppPoint[x][y].y = ppFPoint[x][y].y = newY;
			else
				ppPoint[x][y].y = ppFPoint[x][y].y = 0;
		}

	switch(smoothing)
	{
	case FILTER_NONE:
		CGFilters::OffsetFilterAbs(pBmp, ppPoint);		
		break;
	case FILTER_BILINEAR:
		CGFilters::OffsetFilterAntiAlias(pBmp, ppFPoint);		
		break;
	default:
		// Means that an inappropriate value was passed for smoothing)
		assert(false);
	}

	for (int j = 0; j < pBmp->GetWidth(); ++j)
	{
		delete [] ppPoint[j];
		delete [] ppFPoint[j];
	}

	delete [] ppPoint;
	delete [] ppFPoint;
}

void CGFilters::Sketch(CGBitmap * pBmp, short nDegree)
{
	POINT ** ppPoint = new POINT * [pBmp->GetWidth()];

	for (int i = 0; i < pBmp->GetWidth(); ++i)
		ppPoint[i] = new POINT[pBmp->GetHeight()];

	int nWidth = pBmp->GetWidth(), nHeight = pBmp->GetHeight();

	int newX, newY;

	short nHalf = (short)floor(nDegree/2);

	for (int x = 0; x < nWidth; ++x)
		for (int y = 0; y < nHeight; ++y)
		{
			newX = rand()%nDegree - nHalf;
			
			if (x + newX > 0 && x +newX < nWidth)
				ppPoint[x][y].x = newX;
			else
				ppPoint[x][y].x = 0;

			newY = rand() %nDegree - nHalf;
			
			if (y + newY > 0 && y + newY < nHeight)
				ppPoint[x][y].y = newY;
			else
				ppPoint[x][y].y = 0;
		}

	CGFilters::OffsetFilter(pBmp, ppPoint);		

	for (int j = 0; j < pBmp->GetWidth(); ++j)
		delete [] ppPoint[j];

	delete [] ppPoint;
}

void CGFilters::Pixelate(CGBitmap * pBmp, short pixel, bool bGrid /* = false */)
{
	POINT ** ppPoint = new POINT * [pBmp->GetWidth()];

	for (int i = 0; i < pBmp->GetWidth(); ++i)
		ppPoint[i] = new POINT[pBmp->GetHeight()];

	int nWidth = pBmp->GetWidth(), nHeight = pBmp->GetHeight();

	int newX, newY;

	for (int x = 0; x < nWidth; ++x)
		for (int y = 0; y < nHeight; ++y)
		{
			newX = pixel - x%pixel;
			
			if (bGrid && newX == pixel)
				ppPoint[x][y].x = -x;
			else if (x + newX > 0 && x +newX < nWidth)
				ppPoint[x][y].x = newX;
			else
				ppPoint[x][y].x = 0;

			newY = pixel - y%pixel;
			
			if (bGrid && newY == pixel)
				ppPoint[x][y].y = -y;
			else if (y + newY > 0 && y + newY < nHeight)
				ppPoint[x][y].y = newY;
			else
				ppPoint[x][y].y = 0;
		}

	CGFilters::OffsetFilter(pBmp, ppPoint);		

	for (int j = 0; j < pBmp->GetWidth(); ++j)
		delete [] ppPoint[j];

	delete [] ppPoint;
}

void CGFilters::OffsetFilterAntiAlias(CGBitmap * pBmp, FLOATPOINT ** ppPoint)
{
	int nPixel = 0;

	switch (pBmp->GetBPP())
	{
	case 16:
		nPixel = 2;
		break;
	case 24:
		nPixel = 3;
		break;
	case 32:
		nPixel = 4;
		break;
	default:
		// No palettised images, please, we're British.
		assert(FALSE);
	}

	const int nYOffset = pBmp->GetWidth() * nPixel + pBmp->m_nStride;

	CGBitmap bmp(pBmp);

	double fraction_x, fraction_y, one_minus_x, one_minus_y;
	int ceil_x, ceil_y, floor_x, floor_y;
	BYTE p1, p2;

	unsigned char * pDest = pBmp->GetBits();
	unsigned char * pSource   = bmp.GetBits();

	int width = pBmp->GetWidth();
	int height = pBmp->GetHeight();

	BYTE red, green, blue;

	for (int x = 0; x < width; ++x)
		for (int y = 0; y < height; ++y)
		{
			if (ppPoint[x][y].x  > width - 2 ||
				ppPoint[x][y].x  < 0.0 ||
				ppPoint[x][y].y  < 0.0 ||
				ppPoint[x][y].y  > height - 2)
				continue;

			// Setup

			floor_x = floor(ppPoint[x][y].x);
			floor_y = floor(ppPoint[x][y].y);
			ceil_x = floor_x + 1;
			ceil_y = floor_y + 1;
			fraction_x = ppPoint[x][y].x - floor_x;
			fraction_y = ppPoint[x][y].y - floor_y;
			one_minus_x = 1.0 - fraction_x;
			one_minus_y = 1.0 - fraction_y;

			switch(pBmp->GetBPP())
			{
			case 16:
				p1 = one_minus_x * (double)((*((WORD*)pSource[floor_y * nYOffset + floor_x * nPixel]) & 0x7C00)>>7) +
					fraction_x * (double)((*((WORD*)pSource[floor_y * nYOffset + ceil_x * nPixel]) & 0x7C00)>>7);

				p2 = one_minus_x * (double)((*((WORD*)pSource[ceil_y * nYOffset + floor_x * nPixel]) & 0x7C00)>>7) +
					fraction_x * (double)((*((WORD*)pSource[ceil_y * nYOffset + nPixel * ceil_x]) & 0x7C00)>>7);

				red = (BYTE)(one_minus_y * (double)(p1) + fraction_y * (double)(p2));

				p1 = one_minus_x * (double)((*((WORD*)pSource[floor_y * nYOffset + floor_x * nPixel]) & 0x3E0)>>2) +
					fraction_x * (double)((*((WORD*)pSource[floor_y * nYOffset + ceil_x * nPixel]) & 0x3E0)>>2);

				p2 = one_minus_x * (double)((*((WORD*)pSource[ceil_y * nYOffset + floor_x * nPixel]) & 0x3E0)>>2) +
					fraction_x * (double)((*((WORD*)pSource[ceil_y * nYOffset + nPixel * ceil_x]) & 0x3E0)>>2);

				green = (BYTE)(one_minus_y * (double)(p1) + fraction_y * (double)(p2));

				p1 = one_minus_x * (double)((*((WORD*)pSource[floor_y * nYOffset + floor_x * nPixel]) & 0x1F)<<3) +
					fraction_x * (double)((*((WORD*)pSource[floor_y * nYOffset + ceil_x * nPixel]) & 0x1F)<<3);

				p2 = one_minus_x * (double)((*((WORD*)pSource[ceil_y * nYOffset + floor_x * nPixel]) & 0x1F)<<3) +
					fraction_x * (double)((*((WORD*)pSource[ceil_y * nYOffset + nPixel * ceil_x]) & 0x1F)<<3);

				blue = (BYTE)(one_minus_y * (double)(p1) + fraction_y * (double)(p2));


				*(WORD*)pDest = (( red >> 3) << 10) |
					((green >> 3) << 5) |
					(blue >> 3);
				break;
			case 24:
			case 32:
				// Blue

				p1 = one_minus_x * (double)(pSource[floor_y * nYOffset + floor_x * nPixel]) +
					fraction_x * (double)(pSource[floor_y * nYOffset + ceil_x * nPixel]);

				p2 = one_minus_x * (double)(pSource[ceil_y * nYOffset + floor_x * nPixel]) +
					fraction_x * (double)(pSource[ceil_y * nYOffset + nPixel * ceil_x]);

				pDest[x * nPixel + y*nYOffset] = (BYTE)(one_minus_y * (double)(p1) + fraction_y * (double)(p2));

				// Green

				p1 = one_minus_x * (double)(pSource[floor_y * nYOffset + floor_x * nPixel + 1]) +
					fraction_x * (double)(pSource[floor_y * nYOffset + ceil_x * nPixel + 1]);

				p2 = one_minus_x * (double)(pSource[ceil_y * nYOffset + floor_x * nPixel + 1]) +
					fraction_x * (double)(pSource[ceil_y * nYOffset + nPixel * ceil_x + 1]);
				
				pDest[x * nPixel + y*nYOffset + 1] = (BYTE)(one_minus_y * (double)(p1) + fraction_y * (double)(p2));

				// Blue

				p1 = one_minus_x * (double)(pSource[floor_y * nYOffset + floor_x * nPixel + 2]) +
					fraction_x * (double)(pSource[floor_y * nYOffset + ceil_x * nPixel + 2]);

				p2 = one_minus_x * (double)(pSource[ceil_y * nYOffset + floor_x * nPixel + 2]) +
					fraction_x * (double)(pSource[ceil_y * nYOffset + nPixel * ceil_x + 2]);
				
				pDest[x * nPixel + y*nYOffset + 2] = (BYTE)(one_minus_y * (double)(p1) + fraction_y * (double)(p2));

				break;
			}
		}
}

void CGFilters::OffsetFilter(CGBitmap * pBmp, POINT ** ppPoint)
{
	int nPixel = 0;

	switch (pBmp->GetBPP())
	{
	case 16:
		nPixel = 2;
		break;
	case 24:
		nPixel = 3;
		break;
	case 32:
		nPixel = 4;
		break;
	default:
		// No palettised images, please, we're British.
		assert(FALSE);
	}

	const int nYOffset = pBmp->GetWidth() * nPixel + pBmp->m_nStride;

	CGBitmap bmp(pBmp);

	unsigned char * pDest = pBmp->GetBits();
	unsigned char * pSource   = bmp.GetBits();

	for (int x = 0; x < pBmp->GetWidth(); ++x)
		for (int y = 0; y < pBmp->GetHeight(); ++y)
		{
			switch(pBmp->GetBPP())
			{
			case 16:
				*(WORD*)pSource[x * nPixel + y*nYOffset] =
				*(WORD*)pDest[(x + ppPoint[x][y].x) * nPixel + (y+ppPoint[x][y].y)*nYOffset];
				break;
			case 24:
			case 32:
				pDest[x * nPixel + y*nYOffset] = 
					pSource[(x + ppPoint[x][y].x) * nPixel + (y+ppPoint[x][y].y)*nYOffset];
				pDest[x * nPixel + y*nYOffset + 1] =
					pSource[(x + ppPoint[x][y].x) * nPixel + (y+ppPoint[x][y].y)*nYOffset + 1];
				pDest[x * nPixel + y*nYOffset + 2] =
					pSource[(x + ppPoint[x][y].x) * nPixel + (y+ppPoint[x][y].y)*nYOffset + 2];
				break;
			}
		}
	
}

void CGFilters::OffsetFilterAbs(CGBitmap * pBmp, POINT ** ppPoint)
{
	int nPixel = 0;

	switch (pBmp->GetBPP())
	{
	case 16:
		nPixel = 2;
		break;
	case 24:
		nPixel = 3;
		break;
	case 32:
		nPixel = 4;
		break;
	default:
		// No palettised images, please, we're British.
		assert(FALSE);
	}

	const int nYOffset = pBmp->GetWidth() * nPixel + pBmp->m_nStride;

	CGBitmap bmp(pBmp);

	unsigned char * pDest = pBmp->GetBits();
	unsigned char * pSource   = bmp.GetBits();

	for (int x = 0; x < pBmp->GetWidth(); ++x)
		for (int y = 0; y < pBmp->GetHeight(); ++y)
		{
			switch(pBmp->GetBPP())
			{
			case 16:
				*(WORD*)pSource[x * nPixel + y*nYOffset] =
				*(WORD*)pDest[(x + ppPoint[x][y].x) * nPixel + (y+ppPoint[x][y].y)*nYOffset];
				break;
			case 24:
			case 32:
				pDest[x * nPixel + y*nYOffset] = 
					pSource[(ppPoint[x][y].x) * nPixel + (ppPoint[x][y].y)*nYOffset];
				pDest[x * nPixel + y*nYOffset + 1] =
					pSource[(ppPoint[x][y].x) * nPixel + (ppPoint[x][y].y)*nYOffset + 1];
				pDest[x * nPixel + y*nYOffset + 2] =
					pSource[(ppPoint[x][y].x) * nPixel + (ppPoint[x][y].y)*nYOffset + 2];
				break;
			}
		}
	
}

void CGFilters::MotionBlur(CGBitmap * pBmp, char offset)
{
	int nPixel = 0;

	switch (pBmp->GetBPP())
	{
	case 16:
		nPixel = 2;
		break;
	case 24:
		nPixel = 3;
		break;
	case 32:
		nPixel = 4;
		break;
	default:
		// No palettised images, please, we're British.
		assert(FALSE);
	}

	CGBitmap bmp(pBmp);

	const int nYOffset = pBmp->GetWidth() * nPixel + pBmp->m_nStride;

	unsigned char * pDest = pBmp->GetBits();
	unsigned char * bits = bmp.GetBits();

	unsigned char red, green, blue;

	int width = pBmp->GetWidth();
	int height = pBmp->GetHeight();

	int nTempOffset = offset;

	for (int y = 0; y < pBmp->GetHeight(); ++y)
	{
		for (int x = 0; x < pBmp->GetWidth()-offset; ++x)
		{
			if (x+offset<0)
				nTempOffset = (x==0) ? 0 : -1;
			else if (x + offset > width)
				nTempOffset = (x==width) ? 0 : 1;
			else
				 nTempOffset = offset;

			switch(pBmp->GetBPP())
			{
			case 16:
				red = (*((WORD*)bits) & 0x7C00)>>7;
				green = (*(WORD*)bits&0x3E0)>>2;
				blue = (*(WORD*)bits&0x001F)<<3;

				red = mid (0, BYTE((*((WORD*)(bits + nYOffset - nPixel * 3))&0x7C00 >> 7) +
					(*((WORD*)(bits + nYOffset - nPixel * 2))&0x7C00 >> 7) +
					(*((WORD*)(bits + nYOffset - nPixel))&0x7C00 >> 7) +
					(*((WORD*)(bits + nYOffset))&0x7C00 >> 7) +
					(*((WORD*)(bits + nYOffset + nPixel))&0x7C00 >> 7) +
					(*((WORD*)(bits + nYOffset + nPixel * 2))&0x7C00 >> 7) +
					(*((WORD*)(bits + nYOffset + nPixel * 3))&0x7C00 >> 7) +
					(*((WORD*)(bits - nYOffset - nPixel))&0x7C00 >> 7) +
					(*((WORD*)(bits - nYOffset - nPixel * 2))&0x7C00 >> 7) +
					(*((WORD*)(bits - nYOffset - nPixel * 3))&0x7C00 >> 7) +
					(*((WORD*)(bits - nYOffset))&0x7C00 >> 7) +
					(*((WORD*)(bits - nYOffset + nPixel))&0x7C00 >> 7) +
					(*((WORD*)(bits - nYOffset + nPixel * 2))&0x7C00 >> 7) +
					(*((WORD*)(bits - nYOffset + nPixel * 3))&0x7C00 >> 7))
					, 255);

				green = mid (0, BYTE((*((WORD*)(bits + nYOffset - nPixel * 3))&0x7C00 >> 2) +
					(*((WORD*)(bits + nYOffset - nPixel * 2))&0x7C00 >> 2) +
					(*((WORD*)(bits + nYOffset - nPixel))&0x7C00 >> 2) +
					(*((WORD*)(bits + nYOffset))&0x7C00 >> 2) +
					(*((WORD*)(bits + nYOffset + nPixel))&0x7C00 >> 2) +
					(*((WORD*)(bits + nYOffset + nPixel * 2))&0x7C00 >> 2) +
					(*((WORD*)(bits + nYOffset + nPixel * 3))&0x7C00 >> 2) +
					(*((WORD*)(bits - nYOffset - nPixel))&0x7C00 >> 2) +
					(*((WORD*)(bits - nYOffset - nPixel * 2))&0x7C00 >> 2) +
					(*((WORD*)(bits - nYOffset - nPixel * 3))&0x7C00 >> 2) +
					(*((WORD*)(bits - nYOffset))&0x7C00 >> 2) +
					(*((WORD*)(bits - nYOffset + nPixel))&0x7C00 >> 2) +
					(*((WORD*)(bits - nYOffset + nPixel * 2))&0x7C00 >> 2) +
					(*((WORD*)(bits - nYOffset + nPixel * 3))&0x7C00 >> 2))
					, 255);

				blue = mid (0, BYTE((*((WORD*)(bits + nYOffset - nPixel * 3))&0x001F << 3) +
					(*((WORD*)(bits + nYOffset - nPixel * 2))&0x001F << 3) +
					(*((WORD*)(bits + nYOffset - nPixel))&0x001F << 3) +
					(*((WORD*)(bits + nYOffset))&0x001F << 3) +
					(*((WORD*)(bits + nYOffset + nPixel))&0x001F << 3) +
					(*((WORD*)(bits + nYOffset + nPixel * 2))&0x001F << 3) +
					(*((WORD*)(bits + nYOffset + nPixel * 3))&0x001F << 3) +
					(*((WORD*)(bits - nYOffset - nPixel))&0x001F << 3) +
					(*((WORD*)(bits - nYOffset - nPixel * 2))&0x001F << 3) +
					(*((WORD*)(bits - nYOffset - nPixel * 3))&0x001F << 3) +
					(*((WORD*)(bits - nYOffset))&0x001F << 3) +
					(*((WORD*)(bits - nYOffset + nPixel))&0x001F << 3) +
					(*((WORD*)(bits - nYOffset + nPixel * 2))&0x001F << 3) +
					(*((WORD*)(bits - nYOffset + nPixel * 3))&0x001F << 3))
					, 255);

				*(WORD*)pDest = (( red >> 3) << 10) |
					((green >> 3) << 5) |
					(blue >> 3);
				
				break;
			default:
				red = bits[2];
				green = bits[1];
				blue = bits[0];

				red = mid (0, ((bits)[2] * 2 +
					(bits + nPixel * nTempOffset)[2])/3, 255);

				green = mid (0, ((bits)[1] * 2 +
					(bits + nPixel * nTempOffset)[1])/3, 255);

				blue = mid (0, ((bits)[0] * 2 +
					(bits + nPixel * nTempOffset)[0])/3, 255);

					pDest[0] = blue;
					pDest[1] = green;
					pDest[2] = red;
			}

			bits += nPixel;
			pDest += nPixel;
		}
		bits += pBmp->m_nStride + nPixel * offset;
		pDest += pBmp->m_nStride + nPixel * offset;
	}
}


void CGFilters::TilePuzzle(CGBitmap * pBmp, BYTE nAcross, BYTE nDown)
{
	POINT ** ppPoint = new POINT * [pBmp->GetWidth()];

	for (int i = 0; i < pBmp->GetWidth(); ++i)
		ppPoint[i] = new POINT[pBmp->GetHeight()];

	const int nWidth = pBmp->GetWidth();
	const int nHeight = pBmp->GetHeight();

	const int nTileWidth = nWidth/nAcross;
	const int nTileHeight = nHeight/nDown;

	std::vector<POINT> vecPoints;

	POINT pt;

	// Just in case M$ conforms to the C++ standard one of these days....
	int x;

	for (x = 0; x < nAcross; ++x)
		for(int y = 0; y < nDown; ++y)
		{
			pt.x = x;
			pt.y = y;
			vecPoints.push_back(pt);
		}

	for (x = 0; x < nWidth; ++x)
		for (int y = 0; y < nHeight; ++y)
			ppPoint[x][y].x = ppPoint[x][y].y = 0;

	pt.x = pt.y = 0;
	vecPoints.push_back(pt);

	std::random_shuffle(vecPoints.begin(), vecPoints.end());

	pt = vecPoints[0];

	std::vector<POINT>::iterator it = vecPoints.begin();

	int nTileX = 0, nTileY = 0;

	for(;it != vecPoints.end(); ++it)
	{
		for(int y = nTileY; y < min(nTileY + nTileHeight, nHeight); ++y)
		{
			for (x = nTileX; x < min(nWidth, nTileX + nTileWidth); ++x)
			{
				ppPoint[x][y].x = (x - nTileX + it->x * nTileWidth);
				ppPoint[x][y].y = (y - nTileY + it->y * nTileHeight);
			}
		}

		nTileX += nTileWidth;

		if (nTileX >= nWidth - nWidth % nTileWidth)
		{
			nTileX = 0;
			nTileY += nTileHeight;
		}
	}
	
	CGFilters::OffsetFilterAbs(pBmp, ppPoint);		

	for (int j = 0; j < nWidth; ++j)
		delete [] ppPoint[j];

	delete [] ppPoint;	
}

void CGFilters::Antialias(CGBitmap * pBmp)
{
	int ** ppMatrix = new int * [3];
	for (int x = 0; x < 3; ++x)
		ppMatrix[x] = new int[3];
	
	ppMatrix[0][0] = 1;
	ppMatrix[0][1] = 2;
	ppMatrix[0][2] = 1;
	ppMatrix[1][0] = 2;
	ppMatrix[1][1] = 4;
	ppMatrix[1][2] = 2;
	ppMatrix[2][0] = 1;
	ppMatrix[2][1] = 2;
	ppMatrix[2][2] = 1;

	CGFilters::Convolution3x3(pBmp,ppMatrix, 16, 0);

	for (x = 0; x<3; ++x)
		delete [] ppMatrix[x];
	delete [] ppMatrix;

}
void CGFilters::Flip(CGBitmap * pBmp, bool bHorz, bool bVert)
{
	POINT ** ppPoint = new POINT * [pBmp->GetWidth()];

	for (int i = 0; i < pBmp->GetWidth(); ++i)
		ppPoint[i] = new POINT[pBmp->GetHeight()];

	int nWidth = pBmp->GetWidth(), nHeight = pBmp->GetHeight();

	for (int x = 0; x < nWidth; ++x)
		for (int y = 0; y < nHeight; ++y)
		{
			ppPoint[x][y].x = (bHorz) ? nWidth - (x+1) : x;
			ppPoint[x][y].y = (bVert) ? nHeight - (y + 1) : y;
		}
	
	CGFilters::OffsetFilterAbs(pBmp, ppPoint);		

	for (int j = 0; j < nWidth; ++j)
		delete [] ppPoint[j];

	delete [] ppPoint;	
}

void CGFilters::Histogram(CGBitmap * pBmp, HISTOGRAM_DATA & strHistData)
{
	assert((HBITMAP)*pBmp);

	BYTE red, green, blue, gray;

	unsigned char * bits = pBmp->GetBits();

	int step = 1;

	switch(pBmp->m_BMI.biBitCount)
	{
	case 16:
		step = 2;
		break;
	case 24:
		step = 3;
		break;
	case 32:
		step = 4;
		break;
	default:
		// bitmaps must not have a palette.
		assert(false);
	}

	// Just in case this gets compiled on a non M$ compiler that adheres to the standard
	int y;

	for (y = 0; y < pBmp->m_BMI.biHeight; y++)
	{
		for (int x = 0; x < pBmp->m_BMI.biWidth; ++x)
		{
			if (16 == pBmp->m_BMI.biBitCount)
			{
				red = (*((WORD*)bits) & 0x7C00)>>7;
				green = (*(WORD*)bits&0x3E0)>>2;
				blue = (*(WORD*)bits&0x001F)<<3;				
			}
			else
			{
				red = bits[2];
				green = bits[1];
				blue = bits[0];
			}

			++strHistData.nRed[red];
			++strHistData.nGreen[green];
			++strHistData.nBlue[blue];
			gray = (54 * red + 183 * green + 19 * blue)/256;
			++strHistData.nGray[gray];

			bits += step;
		}

		bits += pBmp->m_nStride;
	}	
	
	if (!strHistData.bFillBitmaps)
		return;

	int nMax = 0;

	for (int i = 0; i < 255; ++i)
	{
		if (strHistData.nRed[i] > nMax)
			nMax = strHistData.nRed[i];
		if (strHistData.nGreen[i] > nMax)
			nMax = strHistData.nGreen[i];
		if (strHistData.nBlue[i] > nMax)
			nMax = strHistData.nBlue[i];
		if (strHistData.nGray[i] > nMax)
			nMax = strHistData.nGray[i];
	}

	strHistData.bmpBlue.Create(260, 260, 24);
	strHistData.bmpGreen.Create(260, 260, 24);
	strHistData.bmpRed.Create(260, 260, 24);
	strHistData.bmpGray.Create(260, 260, 24);

	unsigned char * pRed = strHistData.bmpRed.GetBits();
	unsigned char * pGreen = strHistData.bmpGreen.GetBits();
	unsigned char * pBlue = strHistData.bmpBlue.GetBits();
	unsigned char * pGray = strHistData.bmpGray.GetBits();

	double factor = 256.0 / (double)nMax;

	for (y = 0; y < 260; ++y)
	{
		for (int x = 0; x < 260; ++x)
		{
			if (x < 3 || y < 3)
			{
				pRed[0] = pGreen[0] = pBlue[0] = pGray[0] = strHistData.bBlue;
				pRed[1] = pGreen[1] = pBlue[1] = pGray[1] = strHistData.bGreen;
				pRed[2] = pGreen[2] = pBlue[2] = pGray[2] = strHistData.bRed;
			}
			else
			{
				if ( y - 4 > (int)((double)strHistData.nBlue[x - 4] * factor))
				{
					pBlue[0] = strHistData.bBlue;
					pBlue[1] = strHistData.bGreen;
					pBlue[2] = strHistData.bRed;
				}
				else
				{
					pBlue[0] = strHistData.fBlue;
					pBlue[1] = strHistData.fGreen;
					pBlue[2] = strHistData.fRed;
				}

				if ( y - 4  > (int)((double)strHistData.nRed[x - 4] * factor))
				{
					pRed[0] = strHistData.bBlue;
					pRed[1] = strHistData.bGreen;
					pRed[2] = strHistData.bRed;
				}
				else
				{
					pRed[0] = strHistData.fBlue;
					pRed[1] = strHistData.fGreen;
					pRed[2] = strHistData.fRed;
				}

				if ( y - 4  > (int)((double)strHistData.nGreen[x - 4] * factor))
				{
					pGreen[0] = strHistData.bBlue;
					pGreen[1] = strHistData.bGreen;
					pGreen[2] = strHistData.bRed;
				}
				else
				{
					pGreen[0] = strHistData.fBlue;
					pGreen[1] = strHistData.fGreen;
					pGreen[2] = strHistData.fRed;
				}

				if ( y - 4 > (int)((double)strHistData.nGray[x - 4] * factor))
				{
					pGray[0] = strHistData.bBlue;
					pGray[1] = strHistData.bGreen;
					pGray[2] = strHistData.bRed;
				}
				else
				{
					pGray[0] = strHistData.fBlue;
					pGray[1] = strHistData.fGreen;
					pGray[2] = strHistData.fRed;
				}
			}

			pRed += 3;
			pGreen += 3;
			pBlue += 3;
			pGray += 3;
		}
		pRed += strHistData.bmpRed.m_nStride;
		pGreen += strHistData.bmpGreen.m_nStride;
		pBlue += strHistData.bmpBlue.m_nStride;
		pGray += strHistData.bmpGray.m_nStride;
	}
}

void CGFilters::HistogramEqu(CGBitmap * pBmp, short Type)
{
	HISTOGRAM_DATA data;

	CGFilters::Histogram(pBmp, data);

	const int nWidth = pBmp->GetWidth();
	const int nHeight = pBmp->GetHeight();
	const double nArea = nWidth * nHeight;

	BYTE red, green, blue;

	unsigned char * bits = pBmp->GetBits();

	int step = 1;

	switch(pBmp->m_BMI.biBitCount)
	{
	case 16:
		step = 2;
		break;
	case 24:
		step = 3;
		break;
	case 32:
		step = 4;
		break;
	default:
		// bitmaps must not have a palette.
		assert(false);
	}

	switch (Type)
	{
	case HIST_RED:
		{
//			double dm = 0.0;
			int hist_sum[256];
			int sum = 0;
			
			for (int i = 0; i < 256; ++i)
			{
				sum = sum + data.nRed[i];
				hist_sum[i] = sum;
//				if (data.nRed[i] > 0) ++dm;
			}

		
			for (int y = 0; y < pBmp->m_BMI.biHeight; ++y)
			{
				for (int x = 0; x < pBmp->m_BMI.biWidth; ++x)
				{
					if (16 == pBmp->m_BMI.biBitCount)
					{
						red = (*((WORD*)bits) & 0x7C00)>>7;
						green = (*(WORD*)bits&0x3E0)>>2;
						blue = (*(WORD*)bits&0x001F)<<3;				

						red = (250.0/nArea) * hist_sum[red];

						*(WORD*)bits = (( red >> 3) << 10) |
								((green >> 3) << 5) |
								(blue >> 3);
				
					}
					else
					{
	//					red = bits[2];
	//					green = bits[1];
	//					blue = bits[0];
					
						bits[2] = (250.0/nArea) * hist_sum[bits[2]];					
					}

					bits += step;
				}

				bits += pBmp->m_nStride;
			}	
			
		}
		break;
	case HIST_GREEN:
		{
//			double dm = 0.0;
			int hist_sum[256];
			int sum = 0;
			
			for (int i = 0; i < 256; ++i)
			{
				sum = sum + data.nGreen[i];
				hist_sum[i] = sum;
//				if (data.nGreen[i] > 0) ++dm;
			}

		
			for (int y = 0; y < pBmp->m_BMI.biHeight; ++y)
			{
				for (int x = 0; x < pBmp->m_BMI.biWidth; ++x)
				{
					if (16 == pBmp->m_BMI.biBitCount)
					{
						red = (*((WORD*)bits) & 0x7C00)>>7;
						green = (*(WORD*)bits&0x3E0)>>2;
						blue = (*(WORD*)bits&0x001F)<<3;				

						green = (250.0/nArea) * hist_sum[green];

						*(WORD*)bits = (( red >> 3) << 10) |
								((green >> 3) << 5) |
								(blue >> 3);
				
					}
					else
					{
	//					red = bits[2];
	//					green = bits[1];
	//					blue = bits[0];
					
						bits[1] = (250.0/nArea) * hist_sum[bits[1]];					
					}

					bits += step;
				}

				bits += pBmp->m_nStride;
			}	
			
		}
		break;
	case HIST_BLUE:
		{
//			double dm = 0.0;
			int hist_sum[256];
			int sum = 0;
			
			for (int i = 0; i < 256; ++i)
			{
				sum = sum + data.nBlue[i];
				hist_sum[i] = sum;
//				if (data.nBlue[i] > 0) ++dm;
			}

		
			for (int y = 0; y < pBmp->m_BMI.biHeight; ++y)
			{
				for (int x = 0; x < pBmp->m_BMI.biWidth; ++x)
				{
					if (16 == pBmp->m_BMI.biBitCount)
					{
						red = (*((WORD*)bits) & 0x7C00)>>7;
						green = (*(WORD*)bits&0x3E0)>>2;
						blue = (*(WORD*)bits&0x001F)<<3;				

						blue = (250.0/nArea) * hist_sum[blue];

						*(WORD*)bits = (( red >> 3) << 10) |
								((green >> 3) << 5) |
								(blue >> 3);
				
					}
					else
					{
	//					red = bits[2];
	//					green = bits[1];
	//					blue = bits[0];
					
						bits[0] = (250.0/nArea) * hist_sum[bits[0]];					
					}

					bits += step;
				}

				bits += pBmp->m_nStride;
			}	
			
		}
		break;
	case HIST_ALL:
		{
			int hist_sum_red[256];
			int sumred = 0;
			int hist_sum_green[256];
			int sumgreen = 0;
			int hist_sum_blue[256];
			int sumblue = 0;
			
			for (int i = 0; i < 256; ++i)
			{
				sumred = sumred + data.nRed[i];
				hist_sum_red[i] = sumred;
				sumgreen = sumgreen + data.nGreen[i];
				hist_sum_green[i] = sumgreen;
				sumblue = sumblue + data.nBlue[i];
				hist_sum_blue[i] = sumblue;
			}

		
			for (int y = 0; y < pBmp->m_BMI.biHeight; ++y)
			{
				for (int x = 0; x < pBmp->m_BMI.biWidth; ++x)
				{
					if (16 == pBmp->m_BMI.biBitCount)
					{
						red = (*((WORD*)bits) & 0x7C00)>>7;
						green = (*(WORD*)bits&0x3E0)>>2;
						blue = (*(WORD*)bits&0x001F)<<3;				

						blue = (250.0/nArea) * hist_sum_blue[blue];
						red = (250.0/nArea) * hist_sum_red[red];
						green = (250.0/nArea) * hist_sum_green[green];

						*(WORD*)bits = (( red >> 3) << 10) |
								((green >> 3) << 5) |
								(blue >> 3);
				
					}
					else
					{
						bits[0] = (250.0/nArea) * hist_sum_blue[bits[0]];					
						bits[1] = (250.0/nArea) * hist_sum_green[bits[1]];					
						bits[2] = (250.0/nArea) * hist_sum_red[bits[2]];					
					}

					bits += step;
				}

				bits += pBmp->m_nStride;
			}	
			
		}
		break;
	}
}

/*  Taylors sphere algorithm
void CGFilters::Test(CGBitmap * pBmp, short smoothing)
{
	int nWidth = pBmp->GetWidth(), nHeight = pBmp->GetHeight();

	POINT ** ppPoint = new POINT * [nWidth];
	FLOATPOINT ** ppFPoint = new FLOATPOINT * [nWidth];

	for (int i = 0; i < nWidth; ++i)
	{
		ppFPoint[i] = new FLOATPOINT[nHeight];
		ppPoint[i] = new POINT[nHeight];
	}

	FLOATPOINT mid;
	mid.x = (double)nWidth/2.0;
	mid.y = (double)nHeight/2.0;

	POINT pt;
	pt.x = pt.y = 0;
	double theta;
	double newX, newY;

	const double PiOn2 = 3.1415/2.0;

	for (int x = 0; x < nWidth; ++x)
		for (int y = 0; y < nHeight; ++y)
		{
			theta = asin(((double)x-mid.x)/mid.x);

			newX = (theta + PiOn2) * (mid.x/PiOn2);

			theta = asin(((double)y-mid.y)/mid.y);

			newY = (theta + PiOn2) * (mid.y/PiOn2);
			
			if (newY > 0 && newY < nHeight &&
				newX > 0 && newX < nWidth)
			{
				ppPoint[x][y].x = ppFPoint[x][y]. x = newX;
				ppPoint[x][y].y = ppFPoint[x][y].y = newY;
			}
			else
			{
				ppPoint[x][y].x = ppFPoint[x][y].x = 0;
				ppPoint[x][y].y = ppFPoint[x][y].y = 0;
			}
		}

	switch(smoothing)
	{
	case FILTER_NONE:
		CGFilters::OffsetFilterAbs(pBmp, ppPoint);		
		break;
	case FILTER_BILINEAR:
		CGFilters::OffsetFilterAntiAlias(pBmp, ppFPoint);		
		break;
	default:
		// Means that an inappropriate value was passed for smoothing)
		assert(false);
	}

	for (int j = 0; j < pBmp->GetWidth(); ++j)
	{
		delete [] ppPoint[j];
		delete [] ppFPoint[j];
	}

	delete [] ppPoint;
	delete [] ppFPoint;
}
*/

void CGFilters::NoiseRemovalMean(CGBitmap * pBmp)
{
	const int nWidth = pBmp->GetWidth();
	const int nHeight = pBmp->GetHeight();

	int step = 1;

	switch(pBmp->m_BMI.biBitCount)
	{
	case 16:
		step = 2;
		break;
	case 24:
		step = 3;
		break;
	case 32:
		step = 4;
		break;
	default:
		// bitmaps must not have a palette.
		assert(false);
	}

	CGBitmap bmp(pBmp);

	unsigned char * pDest = pBmp->GetBits();
	unsigned char * pSrc = bmp.GetBits();

	const int nYOffset = nWidth * step + pBmp->m_nStride;

	pSrc += nYOffset;
	pDest += nYOffset;

	BYTE * pByte = new BYTE[9];

	for (int y = 1; y < pBmp->m_BMI.biHeight-1; ++y)
	{
		pSrc += step;
		pDest += step;
		for (int x = 1; x < pBmp->m_BMI.biWidth-1; ++x)
		{
			if (16 == pBmp->m_BMI.biBitCount)
			{
/*				red = (*((WORD*)pSrc) & 0x7C00)>>7;
				green = (*(WORD*)pSrc&0x3E0)>>2;
				blue = (*(WORD*)pSrc&0x001F)<<3;				

				*(WORD*)pDest = (( red >> 3) << 10) |
						((green >> 3) << 5) |
						(blue >> 3);
*/		
			}
			else
			{
				pByte[0] = ((pSrc - nYOffset - step)[0]);
				pByte[1] = ((pSrc - nYOffset)[0]);
				pByte[2] = ((pSrc - nYOffset + step)[0]);
				pByte[3] = ((pSrc - step)[0]);
				pByte[4] = ((pSrc)[0]);
				pByte[5] = ((pSrc + step)[0]);
				pByte[6] = ((pSrc + nYOffset - step)[0]);
				pByte[7] = ((pSrc + nYOffset)[0]);
				pByte[8] = ((pSrc + nYOffset + step)[0]);

				std::sort(pByte, pByte + 9);

				pDest[0] = (BYTE)(std::accumulate(pByte + 2, pByte + 7, 0)/5.0);

				pByte[0] = ((pSrc - nYOffset - step)[1]);
				pByte[1] = ((pSrc - nYOffset)[1]);
				pByte[2] = ((pSrc - nYOffset + step)[1]);
				pByte[3] = ((pSrc - step)[1]);
				pByte[4] = ((pSrc)[1]);
				pByte[5] = ((pSrc + step)[1]);
				pByte[6] = ((pSrc + nYOffset - step)[1]);
				pByte[7] = ((pSrc + nYOffset)[1]);
				pByte[8] = ((pSrc + nYOffset + step)[1]);

				std::sort(pByte, pByte + 9);

				pDest[1] = (BYTE)(std::accumulate(pByte + 2, pByte + 7, 0)/5.0);

				pByte[0] = ((pSrc - nYOffset - step)[2]);
				pByte[1] = ((pSrc - nYOffset)[2]);
				pByte[2] = ((pSrc - nYOffset + step)[2]);
				pByte[3] = ((pSrc - step)[2]);
				pByte[4] = ((pSrc)[2]);
				pByte[5] = ((pSrc + step)[2]);
				pByte[6] = ((pSrc + nYOffset - step)[2]);
				pByte[7] = ((pSrc + nYOffset)[2]);
				pByte[8] = ((pSrc + nYOffset + step)[2]);

				std::sort(pByte, pByte + 9);

				pDest[2] = (BYTE)(std::accumulate(pByte + 2, pByte + 7, 0)/5.0);
			}

			pSrc += step;
			pDest += step;
		}

		pSrc += step;
		pDest += step;
		pSrc += bmp.m_nStride;
		pDest += pBmp->m_nStride;
	}	

	delete [] pByte;
}

void CGFilters::NoiseSaltAndPepper(CGBitmap * pBmp, short Percentage)
{
	const int nWidth = pBmp->GetWidth();
	const int nHeight = pBmp->GetHeight();

	int step = 1;

	switch(pBmp->m_BMI.biBitCount)
	{
	case 16:
		step = 2;
		break;
	case 24:
		step = 3;
		break;
	case 32:
		step = 4;
		break;
	default:
		// bitmaps must not have a palette.
		assert(false);
	}

	unsigned char * pSrc = pBmp->GetBits();

	const int nYOffset = nWidth * step + pBmp->m_nStride;

	srand( (unsigned)time( NULL ) );

	const int iterate = nWidth * nHeight * Percentage/100;

	int x, y;

	BYTE red, green, blue;

	long rand_half = RAND_MAX/2;

	for (int i = 0; i < iterate; ++i)
	{
		x = rand()%nWidth;
		y = rand()%nHeight;

		if (16 == pBmp->m_BMI.biBitCount)
		{
			red = (*(WORD*)(pSrc + (y*nYOffset) + (x * step))& 0x7C00)>>7;
			green = (*(WORD*)(pSrc + (y*nYOffset) + (x * step))&0x3E0)>>2;
			blue = (*(WORD*)(pSrc + (y*nYOffset) + (x * step))&0x001F)<<3;				

			if (rand() > rand_half)
				red = green = blue = 255;
			else
				red = green = blue = 0;

			*(WORD*)(pSrc + (y*nYOffset) + (x * step)) = (( red >> 3) << 10) |
				((green >> 3) << 5) |
				(blue >> 3);
		
			}
			else
			{
				if (rand() > rand_half)
					(pSrc + (y*nYOffset) + (x * step))[0] = (pSrc + (y*nYOffset) + (x * step))[1] = (pSrc + (y*nYOffset) + (x * step))[2] = 255;
				else
					(pSrc + (y*nYOffset) + (x * step))[0] = (pSrc + (y*nYOffset) + (x * step))[1] = (pSrc + (y*nYOffset) + (x * step))[2] = 0;
			}
	}
}

void CGFilters::Test(CGBitmap * pBmp, short RotateDegrees, short nRadius)
{
	const double theta = (double)RotateDegrees * 3.1415/180.0; 
	const int nWidth = pBmp->GetWidth();
	const int nHeight = pBmp->GetHeight();

	int step = 1;

	switch(pBmp->m_BMI.biBitCount)
	{
	case 16:
		step = 2;
		break;
	case 24:
		step = 3;
		break;
	case 32:
		step = 4;
		break;
	default:
		// bitmaps must not have a palette.
		assert(false);
	}

	CGBitmap bmp(pBmp);

	unsigned char * pDest = pBmp->GetBits();
	unsigned char * pSrc = bmp.GetBits();

	const int nYOffset = nWidth * step + pBmp->m_nStride;

	pSrc += nYOffset * nRadius;
	pDest += nYOffset * nRadius;

	BYTE * pByte = new BYTE[9];

	double newX, newY;

	double fraction_x, fraction_y, one_minus_x, one_minus_y;
	int ceil_x, ceil_y, floor_x, floor_y;
	BYTE p1, p2;

	BYTE red, green, blue;

	for (int y = nRadius; y < pBmp->m_BMI.biHeight-nRadius; ++y)
	{
		for (int x = 0; x < pBmp->m_BMI.biWidth; ++x)
		{
			if (16 == pBmp->m_BMI.biBitCount)
			{
/*				red = (*((WORD*)pSrc) & 0x7C00)>>7;
				green = (*(WORD*)pSrc&0x3E0)>>2;
				blue = (*(WORD*)pSrc&0x001F)<<3;				

				*(WORD*)pDest = (( red >> 3) << 10) |
						((green >> 3) << 5) |
						(blue >> 3);
*/		
			}
			else
			{
				newX = nRadius * cos(theta);
				newY = nRadius * sin(theta);

				// Setup

				floor_x = x + floor(newX);
				floor_y = y + floor(newY);
				ceil_x = floor_x + 1;
				ceil_y = floor_y + 1;
				fraction_x = x + newX - floor_x;
				fraction_y = y + newY - floor_y;
				one_minus_x = 1.0 - fraction_x;
				one_minus_y = 1.0 - fraction_y;

				if (floor_x < 0 || floor_y < 0 || ceil_x >= nWidth || ceil_y >= nHeight)
					continue;
				try{
				p1 = one_minus_x * (double)(pSrc[floor_y * nYOffset + floor_x * step]) +
					fraction_x * (double)(pSrc[floor_y * nYOffset + ceil_x * step]);

				p2 = one_minus_x * (double)(pSrc[ceil_y * nYOffset + floor_x * step]) +
					fraction_x * (double)(pSrc[ceil_y * nYOffset + step * ceil_x]);

				blue = (BYTE)(one_minus_y * (double)(p1) + fraction_y * (double)(p2));

				p1 = one_minus_x * (double)(pSrc[floor_y * nYOffset + floor_x * step + 1]) +
					fraction_x * (double)(pSrc[floor_y * nYOffset + ceil_x * step + 1]);

				p2 = one_minus_x * (double)(pSrc[ceil_y * nYOffset + floor_x * step + 1]) +
					fraction_x * (double)(pSrc[ceil_y * nYOffset + step * ceil_x + 1]);

				green = (BYTE)(one_minus_y * (double)(p1) + fraction_y * (double)(p2));

				p1 = one_minus_x * (double)(pSrc[floor_y * nYOffset + floor_x * step + 2]) +
					fraction_x * (double)(pSrc[floor_y * nYOffset + ceil_x * step + 2]);

				p2 = one_minus_x * (double)(pSrc[ceil_y * nYOffset + floor_x * step + 2]) +
					fraction_x * (double)(pSrc[ceil_y * nYOffset + step * ceil_x + 2]);

				red = (BYTE)(one_minus_y * (double)(p1) + fraction_y * (double)(p2));

				// Setup for other pixel

				floor_x = x - floor(newX);
				floor_y = y - floor(newY);
				ceil_x = floor_x + 1;
				ceil_y = floor_y + 1;
				fraction_x = x - newX - floor_x;
				fraction_y = y - newY - floor_y;
				one_minus_x = 1.0 - fraction_x;
				one_minus_y = 1.0 - fraction_y;

				if (floor_x < 0 || floor_y < 0 || ceil_x >= nWidth || ceil_y >= nHeight)
					continue;

				p1 = one_minus_x * (double)(pSrc[floor_y * nYOffset + floor_x * step]) +
					fraction_x * (double)(pSrc[floor_y * nYOffset + ceil_x * step]);

				p2 = one_minus_x * (double)(pSrc[ceil_y * nYOffset + floor_x * step]) +
					fraction_x * (double)(pSrc[ceil_y * nYOffset + step * ceil_x]);

				pDest[nYOffset * y + x * step] = ((BYTE)(one_minus_y * (double)(p1) + fraction_y * (double)(p2))) 
					- blue + 127;

				p1 = one_minus_x * (double)(pSrc[floor_y * nYOffset + floor_x * step + 1]) +
					fraction_x * (double)(pSrc[floor_y * nYOffset + ceil_x * step + 1]);

				p2 = one_minus_x * (double)(pSrc[ceil_y * nYOffset + floor_x * step + 1]) +
					fraction_x * (double)(pSrc[ceil_y * nYOffset + step * ceil_x + 1]);

				pDest[nYOffset * y + x * step + 1] = ((BYTE)(one_minus_y * (double)(p1) + fraction_y * (double)(p2))) 
					- green + 127;

				p1 = one_minus_x * (double)(pSrc[floor_y * nYOffset + floor_x * step + 2]) +
					fraction_x * (double)(pSrc[floor_y * nYOffset + ceil_x * step + 2]);

				p2 = one_minus_x * (double)(pSrc[ceil_y * nYOffset + floor_x * step + 2]) +
					fraction_x * (double)(pSrc[ceil_y * nYOffset + step * ceil_x + 2]);

				pDest[nYOffset * y + x * step + 2] = ((BYTE)(one_minus_y * (double)(p1) + fraction_y * (double)(p2))) 
					- red + 127;
				}
				catch(...)
				{
					int i=0;
				}

/*					pDest[nYOffset * y + x * step] = (pSrc[int(nYOffset * (y+newY) + (x+newX) * step)] - 
						pSrc[int(nYOffset * (y-newY) + (x-newX) * step)]) + 127;
					pDest[nYOffset * y + x * step + 1] = (pSrc[int(nYOffset * (y+newY) + (x+newX) * step) + 1] - 
						pSrc[int(nYOffset * (y-newY) + (x-newX) * step) + 1]) + 127;
					pDest[nYOffset * y + x * step + 2] = (pSrc[int(nYOffset * (y+newY) + (x+newX) * step) + 2] - 
						pSrc[int(nYOffset * (y-newY) + (x-newX) * step) + 2]) + 127;
*/			}
		}
	}	

	delete [] pByte;
}		