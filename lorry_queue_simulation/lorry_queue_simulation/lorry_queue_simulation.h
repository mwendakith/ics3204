
// lorry_queue_simulation.h : main header file for the PROJECT_NAME application
//

#pragma once

#ifndef __AFXWIN_H__
	#error "include 'stdafx.h' before including this file for PCH"
#endif

#include "resource.h"		// main symbols


// Clorry_queue_simulationApp:
// See lorry_queue_simulation.cpp for the implementation of this class
//

class Clorry_queue_simulationApp : public CWinApp
{
public:
	Clorry_queue_simulationApp();

// Overrides
public:
	virtual BOOL InitInstance();

// Implementation

	DECLARE_MESSAGE_MAP()
};

extern Clorry_queue_simulationApp theApp;