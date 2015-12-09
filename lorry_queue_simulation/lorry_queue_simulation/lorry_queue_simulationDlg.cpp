
// lorry_queue_simulationDlg.cpp : implementation file
//

#include "stdafx.h"
#include "lorry_queue_simulation.h"
#include "lorry_queue_simulationDlg.h"
#include "afxdialogex.h"
#include "afxwin.h"



#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CAboutDlg dialog used for App About

class CAboutDlg : public CDialogEx
{
public:
	CAboutDlg();

// Dialog Data
	enum { IDD = IDD_ABOUTBOX };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

// Implementation
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialogEx(CAboutDlg::IDD)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialogEx)
END_MESSAGE_MAP()


// Clorry_queue_simulationDlg dialog



Clorry_queue_simulationDlg::Clorry_queue_simulationDlg(CWnd* pParent /*=NULL*/)
	: CDialogEx(Clorry_queue_simulationDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void Clorry_queue_simulationDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(Clorry_queue_simulationDlg, CDialogEx)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDOK, &Clorry_queue_simulationDlg::OnBnClickedStart)
	ON_WM_TIMER()
END_MESSAGE_MAP()


// Clorry_queue_simulationDlg message handlers

BOOL Clorry_queue_simulationDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		BOOL bNameValid;
		CString strAboutMenu;
		bNameValid = strAboutMenu.LoadString(IDS_ABOUTBOX);
		ASSERT(bNameValid);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	// TODO: Add extra initialization here

	return TRUE;  // return TRUE  unless you set the focus to a control
}

void Clorry_queue_simulationDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialogEx::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void Clorry_queue_simulationDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

// The system calls this function to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR Clorry_queue_simulationDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}



void Clorry_queue_simulationDlg::OnBnClickedStart()
{
	int start_x = 50;
	int start_y = 50;
	int a = 100;
	int b = 100;
	int space = 75;

	std::ifstream in("times.txt");
	skip_heading(in, ':');
	in >> no_processing_units;
	if (no_processing_units < 1) no_processing_units = 1;
	skip_heading(in, ':');
	in >> processing_min;
	sd.processing_length = Time(0, processing_min);
	for (int i = 0; i < no_processing_units; ++i){
		int one = (start_x + a) / 2;
		int two = (start_y + b) / 2;
		sd.pro_units.emplace_back(std::make_unique<Processing_unit>(one, two));
		start_y += space;
		b += space;
	}
	// read input file
	skip_heading(in, ':');
	std::string str;

	
	while (in && !in.eof()) {
		in >> str;
		if (in.fail() || str.length() == 0) break;
		Time arrival_time{ str };
		auto pe = std::make_shared<Arrival>(arrival_time, std::make_shared<Truck>(arrival_time));
		sd.event_queue.emplace(pe);
		pe->set(sd);
	}
	CClientDC dc(this);
	 
	start_x = 50;
	start_y = 50;
	a = 100;
	b = 100;
	space = 75;
	 
	
	for (int counter = 0; counter < no_processing_units; counter++){
		dc.Rectangle(start_x, start_y, a, b);
		start_y += space;
		b += space;
	}
	


	timerID_ = SetTimer(1, 100, 0); // ms
}


void Clorry_queue_simulationDlg::OnTimer(UINT_PTR nIDEvent)
{
	// TODO: Add your control notification handler code here

	time_ += mytime::Time(10);
	CClientDC dc(this);
	std::wostringstream os{};
	os << L"Time = " << time_.wstr();
	auto msg = os.str();
	dc.TextOut(0, 0, msg.c_str());
	static int count{};

	

	while (!sd.event_queue.empty() && sd.event_queue.top()->time() < time_){
		sd.event_queue.top()->run_task(dc);
		sd.event_queue.pop();
	}
}
	
	